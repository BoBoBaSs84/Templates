using DomainName.Application.Interfaces.Infrastructure.Services;
using DomainName.Infrastructure.Installer;
using DomainName.Presentation.Forms;
using DomainName.Presentation.Installer;

using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

using App = System.Windows.Forms.Application;

namespace DomainName;

internal sealed class Program
{
	private static readonly Action<ILogger, string, Exception?> LogInformation =
		LoggerMessage.Define<string>(LogLevel.Information, 0, "{Information}");

	/// <summary>
	/// The main entry point for the application.
	/// </summary>
	[STAThread]
	internal static void Main()
	{
		ApplicationConfiguration.Initialize();

		ServiceCollection services = new();
		ConfigureServices(services);

		using ServiceProvider serviceProvider = services.BuildServiceProvider();

		ILoggerService<Program> logger = serviceProvider.GetRequiredService<ILoggerService<Program>>();
		MainForm mainForm = serviceProvider.GetRequiredService<MainForm>();

		logger.Log(LogInformation, "Starting application..");

		App.Run(mainForm);

		logger.Log(LogInformation, "Quiting application..");
	}

	private static void ConfigureServices(ServiceCollection services)
	{
		_ = services.AddInfrastructureServices();
		_ = services.AddPresentationServices();
	}
}
