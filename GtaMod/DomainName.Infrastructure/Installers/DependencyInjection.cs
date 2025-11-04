using DomainName.Application.Abstractions.Infrastructure.Services;
using DomainName.Infrastructure.Services;

using Microsoft.Extensions.DependencyInjection;

namespace DomainName.Infrastructure.Installers;

/// <summary>
/// The dependency injection installer for infrastructure services.
/// </summary>
public static class DependencyInjection
{
	/// <summary>
	/// Registers infrastructure services for dependency injection.
	/// </summary>
	/// <param name="services">The service collection to add the services to.</param>
	/// <returns>The same <see cref="IServiceCollection"/> collection for chaining.</returns>
	public static IServiceCollection AddInfrastructureServices(this IServiceCollection services)
	{
		services.AddSingleton<ILoggerService, LoggerService>();
		services.AddSingleton<IProviderService, ProviderService>();

		return services;
	}
}
