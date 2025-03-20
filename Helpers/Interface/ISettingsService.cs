namespace ToDoList.Helpers.Interface
{
    public interface ISettingsService
    {
        void SetTheme(AppTheme theme);
        AppTheme GetTheme();
        void ChangeThemeApp();
    }
}