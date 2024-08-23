﻿using Microsoft.Extensions.Logging;
using Randy.Services;
using Randy.ViewModel;
using Randy.View;

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
                });
            
            builder.Services.AddSingleton<MainPage>();
            builder.Services.AddTransient<DetailsPage>();

            builder.Services.AddSingleton<ReminderService>();
            
            builder.Services.AddSingleton<RemindersViewModel>();
            builder.Services.AddTransient<ReminderDetailsViewModel>();

#if DEBUG
    		builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}
