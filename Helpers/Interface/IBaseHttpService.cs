namespace ToDoList.Helpers.Interface
{
    public interface IBaseHttpService<TRequest, TResponse>
    {
        Task<TResponse> CreateItem(TRequest request, string endpoint, string? token = null);
        Task<TResponse> GetItem(string endpoint, string? token = null);
        Task<List<TResponse>?> GetAllItem(string endpoint, string? token = null);
        Task<TResponse> UpdateItem(string endpoint, TRequest request, string? token = null);
        Task<TResponse> DeleteItem(string endpoint, string? token = null);
    }
}