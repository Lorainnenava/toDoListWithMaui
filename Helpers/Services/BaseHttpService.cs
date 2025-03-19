namespace ToDoList.Helpers.Services
{
    public class BaseHttpService<TRequest, TResponse> : IBaseHttpService<TRequest, TResponse>
    {
        private readonly string _urlApi;
        private readonly HttpClient _httpClient;
        private readonly JsonSerializerOptions _serializerOptions;
        private readonly ILogger<BaseHttpService<TRequest, TResponse>> _logger;
        private readonly IDeserializeResponseService<TResponse> _deserializeResponseService;

        public BaseHttpService(IDeserializeResponseService<TResponse> deserializeResponseService, HttpClient httpClient, string urlApi, ILogger<BaseHttpService<TRequest, TResponse>> logger)
        {
            _logger = logger;
            _urlApi = urlApi;
            _httpClient = httpClient;
            _deserializeResponseService = deserializeResponseService;
            _serializerOptions = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
        }

        public HttpRequestMessage CreateRequest(HttpMethod method, string endpoint, object? request = null, string? token = null)
        {
            var requestMessage = new HttpRequestMessage(method, $"{_urlApi}/{endpoint}");

            if (!string.IsNullOrEmpty(token))
            {
                requestMessage.Headers.Authorization = new AuthenticationHeaderValue("Bearer", token);
            }

            if (request != null)
            {
                requestMessage.Content = new StringContent(
                        JsonSerializer.Serialize(request, _serializerOptions),
                        Encoding.UTF8,
                        "application/json"
                    );
            };

            return requestMessage;
        }

        public async Task<TResponse> SendRequestAsync(HttpRequestMessage request)
        {
            try
            {
                HttpResponseMessage response = await _httpClient.SendAsync(request);

                response.EnsureSuccessStatusCode();

                return await _deserializeResponseService.DeserializeAsync(response);
            }
            catch (Exception ex)
            {
                _logger.LogError($"Error en la solicitud HTTP: {ex.Message}");
                throw;
            }
        }

        public async Task<TResponse> CreateItem(TRequest request, string endpoint, string? token = null)
        {
            HttpRequestMessage requestMessaje = CreateRequest(HttpMethod.Post, endpoint, request, token);
            TResponse response = await SendRequestAsync(requestMessaje);
            return response;
        }

        public async Task<TResponse> GetItem(string endpoint, string? token = null)
        {
            HttpRequestMessage requestMessaje = CreateRequest(HttpMethod.Get, endpoint, null, token);
            TResponse response = await SendRequestAsync(requestMessaje);
            return response;
        }

        public async Task<List<TResponse>?> GetAllItem(string endpoint, string? token = null)
        {
            try
            {
                var items = new List<TResponse>();

                HttpRequestMessage requestMessaje = CreateRequest(HttpMethod.Get, endpoint, null, token);

                HttpResponseMessage response = await _httpClient.SendAsync(requestMessaje);

                if (response.IsSuccessStatusCode)
                {
                    string content = await response.Content.ReadAsStringAsync();
                    items = JsonSerializer.Deserialize<List<TResponse>>(content, _serializerOptions);
                }

                return items;
            }
            catch (Exception ex)
            {
                _logger.LogError($"Error al obtener los elementos: {ex.Message}");
                throw;
            }
        }

        public async Task<TResponse> UpdateItem(string endpoint, TRequest request, string? token = null)
        {
            HttpRequestMessage requestMessaje = CreateRequest(HttpMethod.Put, endpoint, request, token);
            TResponse response = await SendRequestAsync(requestMessaje);
            return response;
        }

        public async Task<TResponse> DeleteItem(string endpoint, string? token = null)
        {
            HttpRequestMessage requestMessaje = CreateRequest(HttpMethod.Delete, endpoint, null, token);
            TResponse response = await SendRequestAsync(requestMessaje);
            return response;
        }
    }
}