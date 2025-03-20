namespace ToDoList.Helpers.Services
{
    public class SettingsService : ISettingsService
    {
        private const string ThemeKey = "theme";

        public void SetTheme(AppTheme theme)
        {
            Preferences.Set(ThemeKey, theme.ToString());
            Application.Current.UserAppTheme = theme;
        }

        public AppTheme GetTheme()
        {
            string savedTheme = Preferences.Get(ThemeKey, AppTheme.Light.ToString());
            return Enum.TryParse(savedTheme, out AppTheme theme) ? theme : AppTheme.Light;
        }

        public void ChangeThemeApp()
        {
            AppTheme currentTheme = Application.Current.UserAppTheme;
            AppTheme newTheme = currentTheme is AppTheme.Unspecified or AppTheme.Light ? AppTheme.Dark : AppTheme.Light;
            SetTheme(newTheme);
        }
    }
}