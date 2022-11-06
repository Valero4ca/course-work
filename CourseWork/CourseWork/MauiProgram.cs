using CommunityToolkit.Maui;
using CourseWork.ViewModel;
using Microsoft.Extensions.DependencyInjection;

namespace CourseWork;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
			.UseMauiCommunityToolkit()
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
			});

		builder.Services.AddSingleton<PatientViewModel>();
        builder.Services.AddSingleton<MainPage>();
        return builder.Build();
	}
}
