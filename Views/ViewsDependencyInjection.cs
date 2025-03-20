namespace ToDoList.Views
{
    internal class ViewsDependencyInjection
    {
        public static void RegisterPages(IServiceCollection services)
        {
            services.AddScoped<LoginPage>();
        }
    }
}
