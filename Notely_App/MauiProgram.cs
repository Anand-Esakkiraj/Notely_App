using Microsoft.Extensions.Logging;
using Notely_App.CustomControls;
#if ANDROID
using Notely_App.Platforms.Android.CustomRenderers;
#endif

namespace Notely_App
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .ConfigureMauiHandlers((handlers) =>
                {
#if ANDROID
                    handlers.AddHandler(typeof(CustomEntry),typeof(CustomEntryRenderer));
#endif
                })
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                });

#if DEBUG
    		builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}
