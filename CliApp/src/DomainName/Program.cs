using System.Reflection;

using DomainName.Common;
using DomainName.Extensions;

using Microsoft.Extensions.Hosting;

using Spectre.Console;
using Spectre.Console.Cli;

internal class Program
{
	private static readonly Assembly Assembly = typeof(Program).Assembly;

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
		// Create type registrar
		TypeRegistrar typeRegistrar = new(builder);
		// Create command app
		CommandApp app = new(typeRegistrar);
		// Register available commands
		app.Configure(config => config.ConfigureCommands());

		return app;
	}
}
