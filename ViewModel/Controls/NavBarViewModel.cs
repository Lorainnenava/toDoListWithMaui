namespace ToDoList.ViewModel.Controls
{
    public partial class NavBarViewModel : ObservableObject, INavBarViewModel
    {
        private readonly ISettingsService _settingsService;

        [ObservableProperty]
        string title;

        [ObservableProperty]
        string glyphIcon;

        public NavBarViewModel(ISettingsService settingsService)
        {
            _settingsService = settingsService;
            UpdateGlyphIcon();
        }

        [RelayCommand]
        public void ToggleTheme()
        {
            _settingsService.ChangeThemeApp();
            UpdateGlyphIcon();
        }

        public void UpdateGlyphIcon()
        {
            var currentTheme = Application.Current.UserAppTheme;
            GlyphIcon = currentTheme == AppTheme.Dark ? "\uf186" : "\uf185";
        }
    }
}