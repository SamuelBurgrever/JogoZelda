﻿using Microsoft.Extensions.Logging;

namespace JogoZelda;

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

#if DEBUG
		builder.Logging.AddDebug();
#endif
		#region Dependency Injection
		builder.Services.AddSingleton<IDatabaseService, IDatabaseService>();
        #endregion
        return builder.Build();
	}
}
