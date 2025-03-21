namespace ToDoList.Views
{
    internal class ViewsDependencyInjection
    {
        public static void RegisterPages(IServiceCollection services)
        {
            services.AddScoped<LoginPage>();
            services.AddTransient<RegisterUserPage>();
            services.AddTransient<HomePage>();
        }
    }
}