using DomainName.Presentation.Menus;

using Microsoft.Extensions.DependencyInjection;

namespace DomainName.Presentation.Installers;

/// <summary>
/// The dependency injection installer for presentation services.
/// </summary>
public static class DependencyInjection
{
	/// <summary>
	/// Registers presentation services for dependency injection.
	/// </summary>
	/// <param name="services">The service collection to add the services to.</param>
	/// <returns>The same <see cref="IServiceCollection"/> collection for chaining.</returns>
	public static IServiceCollection AddPresentationServices(this IServiceCollection services)
	{
		services.AddSingleton<ModMenu>();

		return services;
	}
}
