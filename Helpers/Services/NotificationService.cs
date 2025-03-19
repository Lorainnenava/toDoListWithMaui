namespace ToDoList.Utils.Services
{
    public class NotificationService : INotificationService
    {
        public async Task ShowNotification(string message, TypeNotification type)
        {
            SnackbarOptions snackbarOptions;
            CancellationTokenSource cancellationTokenSource = new CancellationTokenSource();

            switch (type)
            {
                case TypeNotification.Correct:
                    snackbarOptions = new()
                    {
                        BackgroundColor = Colors.MediumSeaGreen,
                        TextColor = Colors.White,
                        CornerRadius = new CornerRadius(10)
                    };
                    break;
                case TypeNotification.Error:
                    snackbarOptions = new()
                    {
                        BackgroundColor = Colors.Red,
                        TextColor = Colors.White,
                        CornerRadius = new CornerRadius(10)
                    };
                    break;
                default:
                    snackbarOptions = new()
                    {
                        BackgroundColor = Colors.Orange,
                        TextColor = Colors.White,
                        CornerRadius = new CornerRadius(10)
                    };
                    break;
            }

            var snackbar = Snackbar.Make(message, null, "", TimeSpan.FromSeconds(3), snackbarOptions);

            await snackbar.Show(cancellationTokenSource.Token);
        }
    }
}
