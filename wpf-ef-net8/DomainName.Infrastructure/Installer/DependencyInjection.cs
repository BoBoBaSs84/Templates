using System.Diagnostics.CodeAnalysis;

using DomainName.Infrastructure.Extensions;

using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace DomainName.Infrastructure.Installer;

/// <summary>
/// The infrastructure dependency injection class.
/// </summary>
[SuppressMessage("Style", "IDE0058", Justification = "Not relevant here, dependency injection.")]
public static class DependencyInjection
{
	/// <summary>
	/// Registers the infrastructure services to the service collection.
	/// </summary>
	/// <param name="services">The service collection to enrich.</param>
	/// <param name="configuration">The current configuration instance to use.</param>
	/// <param name="environment">The  host environment instance to use.</param>
	/// <returns>The enriched service collection.</returns>
	public static IServiceCollection RegisterInfrastructureServices(this IServiceCollection services, IConfiguration configuration, IHostEnvironment environment)
	{
		services.RegisterLoggerService(environment)
			.RegisterRepositoryContext(configuration, environment)
			.RegisterScopedServices();

		return services;
	}
}
