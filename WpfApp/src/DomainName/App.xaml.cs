﻿using System.Windows;

using DomainName.Application.Abstractions.Infrastructure.Services;
using DomainName.Extensions;
using DomainName.Presentation.Windows;

using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

using WinApplication = System.Windows.Application;

namespace DomainName;

/// <summary>
/// Interaction logic for App.xaml
/// </summary>
public partial class App : WinApplication
{
	private readonly IHost _host;
	private readonly ILoggerService<App> _loggerService;

	private static readonly Action<ILogger, string, Exception?> LogInformation =
		LoggerMessage.Define<string>(LogLevel.Information, 0, "{Information}");

	private static readonly Action<ILogger, Exception?> LogCritical =
		LoggerMessage.Define(LogLevel.Critical, 0, string.Empty);

	/// <summary>
	/// Initializes a new instance of the app class.
	/// </summary>
	public App()
	{
		_host = CreateHostBuilder().Build();

		_loggerService = _host.Services.GetRequiredService<ILoggerService<App>>();

		DispatcherUnhandledException += (s, e) => OnUnhandledException(e.Exception);
	}

	private async void Application_Startup(object sender, StartupEventArgs e)
	{
		_loggerService.Log(LogInformation, "Application starting...");

		await _host.StartAsync().ConfigureAwait(false);

		MainWindow mainWindow = _host.Services.GetRequiredService<MainWindow>();
		mainWindow.Show();
	}

	private async void Application_Exit(object sender, ExitEventArgs e)
	{
		_loggerService.Log(LogInformation, "Application exiting...");

		using (_host)
			await _host.StopAsync(TimeSpan.FromSeconds(5)).ConfigureAwait(false);
	}

	private void OnUnhandledException(Exception exception)
		=> _loggerService.Log(LogCritical, exception);

	private static IHostBuilder CreateHostBuilder()
	{
		IHostBuilder hostBuilder = Host.CreateDefaultBuilder()
			.RegisterAppSettingsConfiguration()
			.ConfigureServices((context, services) => services.RegisterServices(context.HostingEnvironment));

		return hostBuilder;
	}
}
