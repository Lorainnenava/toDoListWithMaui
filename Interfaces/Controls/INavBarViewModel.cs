namespace ToDoList.Interfaces.Controls
{
    public interface INavBarViewModel
    {
        string Title { get; set; }

        string GlyphIcon { get; set; }

        IRelayCommand ToggleThemeCommand { get; }

        void UpdateGlyphIcon();
    }
}