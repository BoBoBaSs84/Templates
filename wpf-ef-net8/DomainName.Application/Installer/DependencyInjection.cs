using System.Diagnostics.CodeAnalysis;

using DomainName.Application.Extensions;

using Microsoft.Extensions.DependencyInjection;

namespace DomainName.Application.Installer;

/// <summary>
/// The application dependency injection class.
/// </summary>
[SuppressMessage("Style", "IDE0058", Justification = "Not relevant here, dependency injection.")]
public static class DependencyInjection
{
	/// <summary>
	/// Registers the application services to the <paramref name="services"/> collection.
	/// </summary>
	/// <param name="services">The service collection to enrich.</param>
	/// <returns>The enriched service collection.</returns>
	public static IServiceCollection RegisterApplicationServices(this IServiceCollection services)
	{
		services.RegisterApplicationOptions()
			.RegisterNavigationService()
			.RegisterScopedServices()
			.RegisterSingletonServices()
			.RegisterViewModels();

		return services;
	}
}
