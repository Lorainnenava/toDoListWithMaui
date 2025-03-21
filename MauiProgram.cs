namespace ToDoList
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            try
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

                HelpersDependencyInjection.RegisterHelperServices(builder.Services);

                ViewModelDependencyInjection.RegisterViewModels(builder.Services);

                ViewsDependencyInjection.RegisterPages(builder.Services);

#if DEBUG
                builder.Logging.AddDebug();
#endif

                var app = builder.Build();

                ServiceHelper.Services = app.Services;

                return app;
            }
            catch (Exception e)
            {
                throw new Exception("Ha surgido un error" + e.Message);
            }

        }
    }
}
