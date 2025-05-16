﻿using Microsoft.Extensions.Logging;
using BasicCalculator.View;
using CommunityToolkit.Maui;

namespace BasicCalculator
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
                .UseMauiCommunityToolkit();
#if DEBUG
            builder.Logging.AddDebug();
#endif
            builder.Services.AddSingleton<MainPage>();
            builder.Services.AddSingleton<MainPageViewModel>();
            builder.Services.AddTransient<DeterminationOfHydrogenPage>();
            builder.Services.AddTransient<DeterminationOfHydrogenViewModel>();
            builder.Services.AddTransient<DeterminationOfOxygenPage>();
            builder.Services.AddTransient<DeterminationOfOxygenViewModel>();
            builder.Services.AddTransient<DeterminationOfNitrogenPage>();
            builder.Services.AddTransient<DeterminationOfNitrogenViewModel>();
            return builder.Build();
        }
    }
}
