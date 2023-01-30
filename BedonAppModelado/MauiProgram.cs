using BedonAppModelado.Data;

namespace BedonAppModelado;

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

        string dbPath = FileAccessHelper.GetLocalFilePath("frasesApp.db3");
        builder.Services.AddSingleton<Database>(s => ActivatorUtilities.CreateInstance<Database>(s, dbPath));

        return builder.Build();
	}
}
