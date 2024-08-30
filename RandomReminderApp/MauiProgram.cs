using Microsoft.Extensions.Logging;
using Randy.Services;
using Randy.ViewModel;
using Randy.View;
using Plugin.LocalNotification;

namespace Randy
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                })
                .UseLocalNotification();

            builder.Services.AddSingleton<MainPage>();
            builder.Services.AddTransient<DetailsPage>();
            builder.Services.AddTransient<AddPage>();
            builder.Services.AddTransient<EditPage>();

            builder.Services.AddSingleton<ReminderService>();
            
            builder.Services.AddSingleton<RemindersViewModel>();
            builder.Services.AddTransient<ReminderDetailsViewModel>();
            builder.Services.AddSingleton<AddReminderViewModel>();
            builder.Services.AddSingleton<EditReminderViewModel>();

#if DEBUG
    		builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}
