namespace ToDoList.Helpers
{
    public class HelpersDependencyInjection
    {
        public static void RegisterHelperServices(IServiceCollection services)
        {
            services.AddSingleton<INotificationService, NotificationService>();
            services.AddTransient(typeof(IDeserializeResponseService<>), typeof(DeserializeResponseService<>));
            services.AddScoped(typeof(IBaseHttpService<,>), typeof(BaseHttpService<,>));
            services.AddScoped<IConnectivityHelper, ConnectivityHelper>();
            services.AddScoped<IHandleTokenService, HandleTokenService>();
            services.AddSingleton<ISettingsService, SettingsService>();
        }
    }
}