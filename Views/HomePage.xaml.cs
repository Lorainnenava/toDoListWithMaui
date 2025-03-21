namespace ToDoList.Views;

public partial class HomePage : ContentPage
{
    private readonly INavBarViewModel _navBarViewModel;
    public HomePage(INavBarViewModel navBarViewModel)
    {
        InitializeComponent();
        _navBarViewModel = navBarViewModel;
        BindingContext = _navBarViewModel;
    }

    protected override void OnNavigatedTo(NavigatedToEventArgs args)
    {
        base.OnNavigatedTo(args);

        if (_navBarViewModel != null)
        {
            _navBarViewModel.Title = "Inicio";
        }
    }
}