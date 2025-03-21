namespace ToDoList
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute("LoginPage", typeof(LoginPage));
            Routing.RegisterRoute("HomePage", typeof(HomePage));
            Routing.RegisterRoute("RegisterUserPage", typeof(RegisterUserPage));

            CheckUserAuthentication();
        }

        private async void CheckUserAuthentication()
        {
            bool isAuthenticated = Preferences.Get("isLogged", false);

            if (isAuthenticated)
            {
                await GoToAsync("//Dashboard");
            }
            else
            {
                await GoToAsync("//LoginPage");
            }
        }
    }
}
