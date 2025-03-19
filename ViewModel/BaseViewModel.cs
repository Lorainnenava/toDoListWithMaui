namespace ToDoList.ViewModel
{
    public partial class BaseViewModel : ObservableObject, IBaseViewModel
    {
        [ObservableProperty]
        string titlePage;

        [ObservableProperty]
        bool isLoading;

        [ObservableProperty]
        bool isDisabled;
    }
}
