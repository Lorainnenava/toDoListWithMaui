namespace ToDoList.Views;

public partial class RegisterUserPage : ContentPage
{
    private readonly INavBarViewModel _navBarViewModel;
    public RegisterUserPage(INavBarViewModel navBarViewModel)
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
            _navBarViewModel.Title = "Registro de Usuario";
        }
    }
}