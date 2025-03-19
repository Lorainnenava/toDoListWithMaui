namespace ToDoList.Interfaces.ViewModel
{
    public interface ILoginViewModel
    {
        string Email { get; set; }
        string Password { get; set; }
        IAsyncRelayCommand NavigateToRegisterPageCommand { get; }
        IAsyncRelayCommand SaveCommand { get; }
    }
}
