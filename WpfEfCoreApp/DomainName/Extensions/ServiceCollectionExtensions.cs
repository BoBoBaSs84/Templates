using System.Diagnostics.CodeAnalysis;

using DomainName.Application.Installer;
using DomainName.Domain.Installer;
using DomainName.Infrastructure.Installer;
using DomainName.Presentation.Installer;

using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace DomainName.Extensions;

/// <summary>
/// The service collection extensions class.
/// </summary>
[SuppressMessage("Style", "IDE0058", Justification = "Not relevant here, dependency injection.")]
internal static class ServiceCollectionExtensions
{
	/// <summary>
	/// Registers the required services to the service collection.
	/// </summary>
	/// <param name="services">The service collection to enrich.</param>
	/// <param name="configuration">The current configuration.</param>
	/// <param name="environment">The current hosting environment.</param>
	/// <returns>The enriched service collection.</returns>
	internal static IServiceCollection RegisterServices(this IServiceCollection services, IConfiguration configuration, IHostEnvironment environment)
	{
		services.RegisterApplicationServices();
		services.RegisterDomainServices();
		services.RegisterInfrastructureServices(configuration, environment);
		services.RegisterPresentationServices();

		return services;
	}
}
