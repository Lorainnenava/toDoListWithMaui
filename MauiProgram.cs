namespace ToDoList
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .UseMauiCommunityToolkit()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                    fonts.AddFont("fa-solid-900.ttf", "FontAwesomeSolid");
                });

#if DEBUG
            builder.Logging.AddDebug();
            UtilsDependencyInjection.RegisterServices(builder.Services);
            builder.Services.AddScoped<ILoginViewModel, LoginViewModel>();
            builder.Services.AddScoped<LoginPage>();
#endif

            return builder.Build();
        }
    }
}
