namespace ToDoList.ViewModel
{
    public class ViewModelDependencyInjection
    {
        public static void RegisterViewModels(IServiceCollection services)
        {
            services.AddSingleton<IBaseViewModel, BaseViewModel>();
            services.AddSingleton<ILoginViewModel, LoginViewModel>();
            services.AddSingleton<INavBarViewModel, NavBarViewModel>();
        }
    }
}