namespace ToDoList.ViewModel
{
    public partial class BaseViewModel : ObservableObject, IBaseViewModel
    {
        [ObservableProperty]
        bool isLoading;

        [ObservableProperty]
        bool isDisabled;
    }
}