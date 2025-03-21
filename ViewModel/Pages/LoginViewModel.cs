namespace ToDoList.ViewModel
{
    public partial class LoginViewModel : BaseViewModel, ILoginViewModel
    {
        [ObservableProperty]
        string email;

        [ObservableProperty]
        string password;

        private readonly INotificationService _notificationService;

        public LoginViewModel(INotificationService notificationService)
        {
            _notificationService = notificationService;
        }

        [RelayCommand]
        public async Task NavigateToRegisterPage()
        {
            await Shell.Current.GoToAsync("RegisterUserPage");
        }

        [RelayCommand]
        public async Task<bool> Save()
        {
            IsDisabled = true;
            var newSession = new
            {
                Email,
                Password
            };

            if (string.IsNullOrEmpty(newSession.Email) || string.IsNullOrEmpty(newSession.Password))
            {
                IsDisabled = false;
                await _notificationService.ShowNotification("Debe llenar todos los campos", TypeNotification.Warning);
                return false;
            }
            else
            {
                Console.WriteLine(newSession);

                await _notificationService.ShowNotification("Usuario logueado correctamente", TypeNotification.Correct);

                Email = string.Empty;
                Password = string.Empty;

                return true;
            }
        }
    }
}
