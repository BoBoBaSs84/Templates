using DomainName.Application.Abstractions.Application.Services;
using DomainName.Application.Services;

using Microsoft.Extensions.DependencyInjection;

namespace DomainName.Application.Installers;

/// <summary>
/// The dependency injection installer for application services.
/// </summary>
public static class DependencyInjection
{
	/// <summary>
	/// Registers application services for dependency injection.
	/// </summary>
	/// <param name="services">The service collection to add the services to.</param>
	/// <returns>The same <see cref="IServiceCollection"/> collection for chaining.</returns>
	public static IServiceCollection AddApplicationServices(this IServiceCollection services)
	{
		services.AddSingleton<IEventService, EventService>();
		services.AddSingleton<IPedestrianService, PedestrianService>();
		services.AddSingleton<IScriptHookService, ScriptHookService>();

		return services;
	}
}
