namespace ToDoList.Helpers
{
    public class HelpersDependencyInjection
    {
        public static void RegisterHelperServices(IServiceCollection services)
        {
            services.AddScoped(typeof(IBaseHttpService<,>), typeof(BaseHttpService<,>));
            services.AddScoped<IConnectivityHelper, ConnectivityHelper>();
            services.AddTransient(typeof(IDeserializeResponseService<>), typeof(DeserializeResponseService<>));
            services.AddScoped<IHandleTokenService, HandleTokenService>();
            services.AddSingleton<INotificationService, NotificationService>();
            services.AddSingleton<ISettingsService, SettingsService>();
        }
    }
}