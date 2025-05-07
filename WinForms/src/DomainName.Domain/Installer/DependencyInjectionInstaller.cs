using System.Diagnostics.CodeAnalysis;

using DomainName.Domain.Extensions;

using Microsoft.Extensions.DependencyInjection;

namespace DomainName.Domain.Installer;

/// <summary>
/// The domain dependency injection installer class.
/// </summary>
[SuppressMessage("Style", "IDE0058", Justification = "Not relevant here.")]
public static class DependencyInjectionInstaller
{
	/// <summary>
	/// Registers the domain services to the service collection.
	/// </summary>
	/// <param name="services">The service collection to enrich.</param>
	/// <returns>The same service collection instance, so that multiple calls can be chained.</returns>
	public static IServiceCollection RegisterDomainServices(this IServiceCollection services)
	{
		services.RegisterModels();

		return services;
	}
}
