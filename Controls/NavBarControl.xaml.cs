using System.ComponentModel;

namespace ToDoList.Controls;
public partial class NavBarControl : ContentView, INotifyPropertyChanged
{
    public event PropertyChangedEventHandler PropertyChanged;
    public static readonly BindableProperty TitleProperty =
            BindableProperty.Create(nameof(Title), typeof(string), typeof(NavBarControl), string.Empty, BindingMode.TwoWay);

    public string Title
    {
        get => (string)GetValue(TitleProperty);
        set => SetValue(TitleProperty, value);
    }

    public static readonly BindableProperty GlyphIconProperty =
    BindableProperty.Create(nameof(GlyphIcon), typeof(string), typeof(NavBarControl), string.Empty, BindingMode.TwoWay);

    public string GlyphIcon
    {
        get => (string)GetValue(GlyphIconProperty);
        set => SetValue(GlyphIconProperty, value);
    }

    public NavBarControl()
    {
        InitializeComponent();
    }
}