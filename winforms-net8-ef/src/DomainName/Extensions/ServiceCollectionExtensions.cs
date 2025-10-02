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
/// The <see cref="IServiceCollection"/> extensions class.
/// </summary>
[SuppressMessage("Style", "IDE0058", Justification = "Not relevant here, dependency injection.")]
internal static class ServiceCollectionExtensions
{
	/// <summary>
	/// Registers the all the required services to the <paramref name="services"/> collection.
	/// </summary>
	/// <param name="services">The service collection to enrich.</param>
	/// <param name="configuration">The configuration instance to use.</param>
	/// <param name="environment">The host environment instance to use.</param>
	/// <returns>The enriched service collection.</returns>
	internal static IServiceCollection RegisterServices(this IServiceCollection services, IConfiguration configuration, IHostEnvironment environment)
	{
		services.RegisterApplicationServices()
			.RegisterDomainServices()
			.RegisterInfrastructureServices(configuration, environment)
			.RegisterPresentationServices();

		return services;
	}
}
