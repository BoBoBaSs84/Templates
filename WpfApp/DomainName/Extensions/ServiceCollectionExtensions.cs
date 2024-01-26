using System.Diagnostics.CodeAnalysis;

using DomainName.Application.Installer;
using DomainName.Domain.Installer;
using DomainName.Infrastructure.Installer;
using DomainName.Presentation.Installer;

using Microsoft.Extensions.DependencyInjection;

namespace DomainName.Extensions;

/// <summary>
/// The service collection extensions class.
/// </summary>
[SuppressMessage("Style", "IDE0058", Justification = "Not relevant here.")]
internal static class ServiceCollectionExtensions
{
	/// <summary>
	/// Registers the required services to the service collection.
	/// </summary>
	/// <param name="services">The service collection to enrich.</param>
	/// <returns>The enriched service collection.</returns>
	internal static IServiceCollection RegisterServices(this IServiceCollection services)
	{
		services.RegisterApplicationServices();
		services.RegisterDomainServices();
		services.RegisterInfrastructureServices();
		services.RegisterPresentationServices();

		return services;
	}
}
