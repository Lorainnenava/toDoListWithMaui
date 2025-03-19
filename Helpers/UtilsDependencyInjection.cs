namespace ToDoList.Helpers
{
    public class UtilsDependencyInjection
    {
        public static void RegisterServices(IServiceCollection services)
        {
            services.AddTransient<INotificationService, NotificationService>();
            services.AddTransient(typeof(IDeserializeResponseService<>), typeof(DeserializeResponseService<>));
            services.AddScoped(typeof(IBaseHttpService<,>), typeof(BaseHttpService<,>));
        }
    }
}