using DomainName.Application.Interfaces.Infrastructure.Services;
using DomainName.Infrastructure.Services;

using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Microsoft.Extensions.Logging;

namespace DomainName.Infrastructure.Extensions;

/// <summary>
/// The infrastructure service collection extensions.
/// </summary>
internal static class ServiceCollectionExtensions
{
	/// <summary>
	/// Adds the logger service to the service collection.
	/// </summary>
	/// <param name="services">The service collection to enrich.</param>
	/// <returns>The enriched service collection.</returns>
	internal static ServiceCollection AddLoggerService(this ServiceCollection services)
	{
		services.TryAddSingleton(typeof(ILoggerService<>), typeof(LoggerService<>));
		
		services.AddLogging(config =>
		{
			config.AddDebug();
			config.AddConsole();
#if DEBUG
			config.SetMinimumLevel(LogLevel.Debug);
#else
			config.SetMinimumLevel(LogLevel.Error);
#endif
		});

		return services;
	}
}
