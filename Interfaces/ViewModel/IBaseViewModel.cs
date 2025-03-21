namespace ToDoList.Interfaces.ViewModel
{
    public interface IBaseViewModel
    {
        bool IsLoading { get; set; }
        bool IsDisabled { get; set; }
    }
}
