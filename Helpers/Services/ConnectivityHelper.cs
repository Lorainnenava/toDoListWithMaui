namespace ToDoList.Helpers.Services
{
    public class ConnectivityHelper : IConnectivityHelper
    {
        public bool IsConnected()
        {
            return Connectivity.Current.NetworkAccess == NetworkAccess.Internet;
        }

        public void SubscribeToConnectivityChanges(Action<bool> onConnectivityChanged)
        {
            Connectivity.Current.ConnectivityChanged += (sender, args) =>
            {
                bool isConnected = args.NetworkAccess == NetworkAccess.Internet;
                onConnectivityChanged?.Invoke(isConnected);
            };
        }
    }
}