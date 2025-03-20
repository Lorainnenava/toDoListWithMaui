namespace ToDoList.ViewModel
{
    public class ViewModelDependencyInjection
    {
        public static void RegisterViewModels(IServiceCollection services)
        {
            services.AddSingleton<ILoginViewModel, LoginViewModel>();
        }
    }
}
