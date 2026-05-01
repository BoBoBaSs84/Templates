using System.Globalization;
using System.Windows;

using DomainName.Application.Abstractions.Application.Services;
using DomainName.Application.Abstractions.Infrastructure.Services;
using DomainName.Application.Enumerators;
using DomainName.Application.Events;
using DomainName.Application.Settings;
using DomainName.Extensions;
using DomainName.Presentation.Windows;

using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

using RESX = DomainName.Properties.Resources;
using WpfApp = System.Windows.Application;

namespace DomainName;

/// <summary>
/// Interaction logic for App.xaml
/// </summary>
public partial class App : WpfApp
{
	private readonly IHost _host;
	private readonly IEventService _eventService;
	private readonly ILoggerService<App> _loggerService;

	private static readonly Action<ILogger, string, Exception?> LogInformation =
		LoggerMessage.Define<string>(LogLevel.Information, 0, "{Information}");

	private static readonly Action<ILogger, string, Exception?> LogWarning =
		LoggerMessage.Define<string>(LogLevel.Warning, 0, "{Warning}");

	private static readonly Action<ILogger, Exception?> LogCritical =
		LoggerMessage.Define(LogLevel.Critical, 0, string.Empty);

	/// <summary>
	/// Initializes a new instance of the <see cref="App"/> class.
	/// </summary>
	public App()
	{
		_host = CreateHostBuilder().Build();

		_eventService = _host.Services.GetRequiredService<IEventService>();
		_loggerService = _host.Services.GetRequiredService<ILoggerService<App>>();

		RegisterEventHandlers();

		SetApplicationanguage();
	}

	private async void Application_Startup(object sender, StartupEventArgs e)
	{
		_loggerService.Log(LogInformation, RESX.ApplicationIsStarting);

		await _host.StartAsync().ConfigureAwait(false);

		MainWindow mainWindow = _host.Services.GetRequiredService<MainWindow>();
		mainWindow.Show();
	}

	private async void Application_Exit(object sender, ExitEventArgs e)
	{
		_loggerService.Log(LogInformation, RESX.ApplicationIsExiting);

		using (_host)
			await _host.StopAsync(TimeSpan.FromSeconds(5)).ConfigureAwait(false);
	}

	private static IHostBuilder CreateHostBuilder()
	{
		IHostBuilder hostBuilder = Host.CreateDefaultBuilder()
			.RegisterAppSettingsConfiguration()
			.ConfigureServices((context, services) => services.RegisterServices(context.HostingEnvironment));

		return hostBuilder;
	}

	private void RegisterEventHandlers()
	{
		DispatcherUnhandledException += (s, e) => OnUnhandledException(e.Exception);
		_eventService.Subscribe<RestartRequestedEvent>(OnRestartRequested);
		_eventService.Subscribe<ExitRequestedEvent>(OnExitRequested);
	}

	private void OnUnhandledException(Exception exception)
		=> _loggerService.Log(LogCritical, exception);

	private void OnExitRequested(ExitRequestedEvent @event)
	{
		_loggerService.Log(LogInformation, RESX.ExitRequested);
		Current.Shutdown();
	}

	private void OnRestartRequested(RestartRequestedEvent @event)
	{
		_loggerService.Log(LogInformation, RESX.RestartRequested);
		System.Diagnostics.Process.Start(Environment.ProcessPath!);
		Current.Shutdown();
	}

	private void SetApplicationanguage()
	{
		_host.Services.GetRequiredService<ISettingsService>()
			.LoadAsync().GetAwaiter().GetResult();

		string language = _host.Services.GetRequiredService<ApplicationSettings>()
			.General.Language.GetDescriptionFast();

		try
		{
			CultureInfo cultureInfo = CultureInfo.GetCultureInfo(language);
			CultureInfo.DefaultThreadCurrentCulture = cultureInfo;
			CultureInfo.DefaultThreadCurrentUICulture = cultureInfo;

			_loggerService.Log(LogInformation, $"Application language set to '{language}'.");
		}
		catch (CultureNotFoundException)
		{
			_loggerService.Log(LogWarning, $"Could not set application language to '{language}'. Culture not found.");
		}
	}
}
