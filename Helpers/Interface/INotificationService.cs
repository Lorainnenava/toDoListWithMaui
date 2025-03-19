namespace ToDoList.Helpers.Interface
{
    public interface INotificationService
    {
        Task ShowNotification(string message, TypeNotification type);
    }
}
