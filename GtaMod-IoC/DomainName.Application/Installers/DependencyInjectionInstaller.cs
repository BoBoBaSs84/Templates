using DomainName.Application.Interfaces.Application.Services;
using DomainName.Application.Services;

using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;

namespace DomainName.Application.Installers;

/// <summary>
/// The dependency injection installer class.
/// </summary>
public static class DependencyInjectionInstaller
{
	/// <summary>
	/// Enriches a service collection with the application services.
	/// </summary>
	/// <param name="services">The service collection to enrich.</param>
	/// <returns>The enriched service collection.</returns>
	public static IServiceCollection AddApplicationServices(this IServiceCollection services)
	{
		services.TryAddTransient<IMainScript, MainScript>();

		return services;
	}
}
