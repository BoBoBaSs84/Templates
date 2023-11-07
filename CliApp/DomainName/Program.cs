using DomainName.Infrastructure;
using DomainName.Infrastructure.Installers;

using Microsoft.Extensions.DependencyInjection;

using Spectre.Console.Cli;

namespace DomainName;

internal sealed class Program
{
	internal static int Main(string[] args)
	{
		IServiceCollection services = new ServiceCollection();
		services.AddInfrastructureServices();
		TypeRegistrar registrar = new(services);

		// Create a new command app with the registrar
		// and run it with the provided arguments.
		CommandApp app = new(registrar);
		return app.Run(args);
	}
}
