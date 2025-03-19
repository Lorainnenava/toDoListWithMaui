namespace ToDoList.Helpers.Services
{
    public class DeserializeResponseService<T> : IDeserializeResponseService<T>
    {
        private readonly JsonSerializerOptions _serializerOptions;

        public DeserializeResponseService()
        {
            _serializerOptions = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
        }

        public async Task<T> DeserializeAsync(HttpResponseMessage response)
        {
            string contentResponse = await response.Content.ReadAsStringAsync();

            if (!response.IsSuccessStatusCode)
            {
                throw new ApiException(contentResponse, response.StatusCode);
            }

            if (string.IsNullOrWhiteSpace(contentResponse))
            {
                throw new ApiException("La API devolvió una respuesta vacía o nula.", response.StatusCode);
            }

            try
            {
                return JsonSerializer.Deserialize<T>(contentResponse, _serializerOptions)
                    ?? throw new ApiException("Error al deserializar la respuesta.", response.StatusCode);
            }
            catch (JsonException ex)
            {
                throw new ApiException($"Error al procesar la respuesta JSON: {ex.Message}", response.StatusCode);
            }
        }
    }
}
