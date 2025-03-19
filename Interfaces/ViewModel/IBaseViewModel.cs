namespace ToDoList.Interfaces.ViewModel
{
    public interface IBaseViewModel
    {
        string TitlePage { get; set; }
        bool IsLoading { get; set; }
        bool IsDisabled { get; set; }
    }
}
