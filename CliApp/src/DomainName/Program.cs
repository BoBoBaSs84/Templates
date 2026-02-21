using System.Reflection;

using DomainName.Abstractions.Services;
using DomainName.Common;
using DomainName.Events;
using DomainName.Extensions;

using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

using Spectre.Console;
using Spectre.Console.Cli;

internal class Program
{
	private static readonly Assembly Assembly = typeof(Program).Assembly;
	private static readonly Action<ILogger, Exception?> LogCritical =
		LoggerMessage.Define(LogLevel.Critical, 0, string.Empty);

	private static IEventService s_eventService = default!;
	private static ILoggerService<Program> s_loggerService = default!;

	private static async Task Main(string[] args)
	{
		AnsiConsole.Write(new FigletText($"{Assembly.GetName().Name}"));
		AnsiConsole.WriteLine($"{Assembly.GetName().Name} Command-line-interface {Assembly.GetName().Version}");
		AnsiConsole.WriteLine();

		CommandApp app = CreateCommandApp(args);

		await app.RunAsync(args)
			.ConfigureAwait(false);
	}

	private static CommandApp CreateCommandApp(string[] args)
	{
		// Create host builder
		IHostBuilder builder = Host.CreateDefaultBuilder(args)
			.ConfigureServices((context, services) => services.RegisterServices(context.HostingEnvironment));

		IServiceProvider serviceProvider = builder.Build().Services;
		s_eventService = serviceProvider.GetRequiredService<IEventService>();
		s_loggerService = serviceProvider.GetRequiredService<ILoggerService<Program>>();

		AppDomain.CurrentDomain.UnhandledException += (s, e) => OnUnhandledException(e.ExceptionObject as Exception);

		// Create type registrar
		TypeRegistrar typeRegistrar = new(builder);
		// Create command app
		CommandApp app = new(typeRegistrar);
		// Register available commands
		app.Configure(config => config.ConfigureCommands());

		return app;
	}

	private static void OnUnhandledException(Exception? exception)
	{
		s_loggerService.Log(LogCritical, exception);
		s_eventService.Publish(new ExceptionEvent("An unhandled exception has occurred.", exception));
	}
}
