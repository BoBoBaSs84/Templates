using DomainName.Application.Interfaces.Infrastructure.Services;
using DomainName.Infrastructure.Installer;
using DomainName.Presentation.Forms;
using DomainName.Presentation.Installer;

using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

using FormsApplication = System.Windows.Forms.Application;

namespace DomainName;

internal sealed class Program
{
	private static ILoggerService<Program> s_logger = default!;
	private static IServiceProvider s_serviceProvider = default!;

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
		IHost host = CreateDefaultBuilder().Build();

		s_serviceProvider = host.Services;
		s_logger = GetService<ILoggerService<Program>>();
		AppDomain.CurrentDomain.UnhandledException += OnUnhandledException;

		s_logger.Log(LogInformation, "Starting application..");

		MainForm mainForm = GetService<MainForm>();
		FormsApplication.Run(mainForm);

		s_logger.Log(LogInformation, "Quiting application..");
	}

	public static T GetService<T>()
		=> s_serviceProvider.GetRequiredService(typeof(T)) is not T service
		? throw new ArgumentException($"{typeof(T)} needs to be a registered service.")
		: service;

	private static IHostBuilder CreateDefaultBuilder()
		=> Host.CreateDefaultBuilder()
		.ConfigureServices((context, services) =>
		{
			_ = services.AddInfrastructureServices();
			_ = services.AddPresentationServices();
		});

	private static void OnUnhandledException(object sender, UnhandledExceptionEventArgs args)
	{
		Exception? ex = args.ExceptionObject as Exception;
		s_logger.Log(LogCritical, ex);
	}
}
