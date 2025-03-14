using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using ToDoList.Interfaces;

namespace ToDoList.ViewModel
{
    public partial class LoginViewModel: ILoginViewModel
    {
        //[ObservableProperty]
        //string email;

        //[ObservableProperty]
        //string password;
        [RelayCommand()]
        public async Task NavigateToRegisterPage()
        {
            await Shell.Current.GoToAsync("RegisterPage");
        }
    }
}
