namespace ToDoList.Helpers.Interface
{
    public interface IDeserializeResponseService<T>
    {
        Task<T> DeserializeAsync(HttpResponseMessage response);
    }
}
