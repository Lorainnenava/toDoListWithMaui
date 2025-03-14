using CommunityToolkit.Mvvm.Input;

namespace ToDoList.Interfaces
{
    public interface ILoginViewModel
    {
        //string Email { get; set; }
        //string Password { get; set; }
        IAsyncRelayCommand NavigateToRegisterPageCommand{ get; }
    }
}
