namespace ToDoList
{
    public partial class App : Application
    {
        private readonly SettingsService _settingsService;
        public App()
        {
            InitializeComponent();
            _settingsService = new SettingsService();
            UserAppTheme = _settingsService.GetTheme();
        }

        protected override Window CreateWindow(IActivationState? activationState)
        {
            return new Window(new AppShell());
        }
    }
}
