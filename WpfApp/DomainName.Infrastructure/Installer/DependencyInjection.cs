using DomainName.Infrastructure.Extensions;

using Microsoft.Extensions.DependencyInjection;

namespace DomainName.Infrastructure.Installer;

/// <summary>
/// The infrastructure dependency injection class.
/// </summary>
public static class DependencyInjection
{
	/// <summary>
	/// Registers the infrastructure services to the service collection.
	/// </summary>
	/// <param name="services">The service collection to enrich.</param>
	/// <returns>The enriched service collection.</returns>
	public static IServiceCollection AddInfrastructureServices(this IServiceCollection services)
	{
		services.AddLoggerService();

		return services;
	}
}
