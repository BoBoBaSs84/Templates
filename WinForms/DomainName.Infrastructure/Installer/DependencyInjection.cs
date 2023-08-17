using DomainName.Infrastructure.Extensions;

using Microsoft.Extensions.DependencyInjection;

namespace DomainName.Infrastructure.Installer;

/// <summary>
/// The infrastructure dependency injection class.
/// </summary>
public static class DependencyInjection
{
	/// <summary>
	/// Adds the infrastructure services to the service collection.
	/// </summary>
	/// <param name="services">The service collection to enrich.</param>
	/// <returns>The enriched service collection.</returns>
	public static ServiceCollection AddInfrastructureServices(this ServiceCollection services)
	{
		services.AddLoggerService();

		return services;
	}
}
