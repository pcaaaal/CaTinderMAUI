using Microsoft.Extensions.Logging;

namespace CaTinder;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("SF-Pro-Text-Regular.otf", "SFProRegular");
				fonts.AddFont("SF-Pro-Text-Semibold.otf", "SFProSemibold");
			});

#if DEBUG
		builder.Logging.AddDebug();
#endif

		return builder.Build();
	}
}
