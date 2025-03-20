namespace ToDoList.Helpers.Interface
{
    public interface IHandleTokenService
    {
        Task<string> IsTokenExist();
        Task<(bool success, string? value)> HandleTokenAsync(TypeActionToken typeAction, string? token = null);
    }
}