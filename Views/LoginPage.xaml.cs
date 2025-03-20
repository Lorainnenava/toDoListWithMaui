namespace ToDoList.Views;

public partial class LoginPage : ContentPage
{
    public LoginPage(ILoginViewModel viewModel)
    {
        InitializeComponent();
        BindingContext = viewModel;
    }
}