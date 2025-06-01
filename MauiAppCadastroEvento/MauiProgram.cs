using Microsoft.Extensions.Logging;

namespace MauiAppCadastroEvento
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
                    fonts.AddFont("Quicksand-Bold.ttf", "QB");
                    fonts.AddFont("Quicksand-Light.ttf", "QL");
                    fonts.AddFont("Quicksand-Medium.ttf", "QM");
                    fonts.AddFont("Quicksand-Regular.ttf", "QR");
                    fonts.AddFont("Quicksand-SemiBold.ttf", "QS");
                });

#if DEBUG
    		builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}
