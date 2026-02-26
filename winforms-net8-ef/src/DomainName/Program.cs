using System.Globalization;

using DomainName.Application.Abstractions.Application.Services;
using DomainName.Application.Abstractions.Infrastructure.Services;
using DomainName.Application.Events;
using DomainName.Application.Extensions;
using DomainName.Extensions;
using DomainName.Presentation.Forms;

using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

using WinFormsApp = System.Windows.Forms.Application;

namespace DomainName;

internal sealed class Program
{
	private static IHost s_host = default!;
	private static IEventService s_eventService = default!;
	private static ILoggerService<Program> s_logger = default!;
	private static ISettingsService s_settingsService = default!;

	private static readonly Action<ILogger, string, Exception?> LogInformation =
		LoggerMessage.Define<string>(LogLevel.Information, 0, "{Information}");

	private static readonly Action<ILogger, Exception?> LogCritical =
		LoggerMessage.Define(LogLevel.Critical, 0, string.Empty);

	/// <summary>
	/// The main entry point for the application.
	/// </summary>
	[STAThread]
	internal static void Main()
	{
		ApplicationConfiguration.Initialize();

		s_host = CreateDefaultBuilder().Build();
		s_eventService = s_host.Services.GetRequiredService<IEventService>();
		s_logger = s_host.Services.GetRequiredService<ILoggerService<Program>>();
		s_settingsService = s_host.Services.GetRequiredService<ISettingsService>();

		RegisterEventHandlers();
		SetLanguage();

		s_logger.Log(LogInformation, "The application is starting ...");
		s_host.Start();

		MainForm mainForm = s_host.Services.GetRequiredService<MainForm>();
		WinFormsApp.Run(mainForm);

		s_logger.Log(LogInformation, "The application is shutting down ...");
	}

	private static void RegisterEventHandlers()
	{
		AppDomain.CurrentDomain.UnhandledException += (s, e) => OnUnhandledException(e.ExceptionObject as Exception);
		s_eventService.Subscribe<ExitApplicationEvent>(OnExitApplication);
		s_eventService.Subscribe<RestartApplicationEvent>(OnRestartApplication);
	}

	private static void SetLanguage()
	{
		CultureInfo cultureInfo = s_settingsService
			.GetLanguage()
			.GetCultureInfo();

		Thread.CurrentThread.CurrentCulture = cultureInfo;
		Thread.CurrentThread.CurrentUICulture = cultureInfo;

		s_logger.Log(LogInformation, $"Application language was set to '{cultureInfo}'.");
	}

	private static void OnExitApplication(ExitApplicationEvent @event)
	{
		s_logger.Log(LogInformation, "Application exit event was called.");
		WinFormsApp.Exit();
	}

	private static void OnRestartApplication(RestartApplicationEvent @event)
	{
		s_logger.Log(LogInformation, "Application restart event was called.");
		WinFormsApp.Restart();
	}

	private static void OnUnhandledException(Exception? exception)
		=> s_logger.Log(LogCritical, exception);

	private static IHostBuilder CreateDefaultBuilder()
	{
		IHostBuilder hostBuilder = Host.CreateDefaultBuilder()
			.RegisterAppSettingsConfiguration()
			.ConfigureServices((context, services) => services.RegisterServices(context.HostingEnvironment));

		return hostBuilder;
	}
}
