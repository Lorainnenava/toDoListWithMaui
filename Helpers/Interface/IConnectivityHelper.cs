namespace ToDoList.Helpers.Interface
{
    public interface IConnectivityHelper
    {
        bool IsConnected();
        void SubscribeToConnectivityChanges(Action<bool> onConnectivityChanged);
    }
}
