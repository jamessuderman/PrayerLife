namespace PrayerLife;

public static class MauiProgram
{
    public static MauiApp CreateMauiApp()
    {
        var builder = MauiApp.CreateBuilder();
        builder
            .UseMauiApp<App>()
            .ConfigureFonts(fonts =>
            {
                fonts.AddFont("FiraSans-Black.ttf", "FiraBlack");
                fonts.AddFont("FiraSans-Bold.ttf", "FiraBold");
                fonts.AddFont("FiraSans-Regular.ttf", "FiraRegular");
                fonts.AddFont("FiraSans-Light.ttf", "FiraLight");
                fonts.AddFont("FiraSans-Thin.ttf", "FiraThin");
            });

        // Views
        builder.Services.AddSingleton<MainPage>();
        builder.Services.AddTransient<DetailPage>();
        
        // ViewModels
        builder.Services.AddSingleton<MainViewModel>();
        builder.Services.AddTransient<DetailViewModel>();

        // Services
        builder.Services.AddSingleton<IRequestService, RequestService>();

#if DEBUG
        builder.Logging.AddDebug();
#endif

        return builder.Build();
    }
}

