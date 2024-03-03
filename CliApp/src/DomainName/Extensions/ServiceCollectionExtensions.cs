using System.Diagnostics.CodeAnalysis;

using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

using DomainName.Interfaces;

using DomainName.Services;

namespace DomainName.Extensions;

/// <summary>
/// The service collection extensions class.
/// </summary>
[SuppressMessage("Style", "IDE0058", Justification = "Not relevant here.")]
internal static class ServiceCollectionExtensions
{
	/// <summary>
	/// Registers the application services to the service collection.
	/// </summary>
	/// <param name="services">The service collection to enrich.</param>
	/// <param name="environment">The host environment instance to use.</param>
	/// <returns>The enriched service collection.</returns>	
	internal static IServiceCollection RegisterServices(this IServiceCollection services, IHostEnvironment environment)
	{
		services.RegisterLoggerService(environment);

		services.AddSingleton<WeatherForecastService>();

		return services;
	}

	[SuppressMessage("Interoperability", "CA1416", Justification = "Validate platform compatibility done.")]
	private static IServiceCollection RegisterLoggerService(this IServiceCollection services, IHostEnvironment environment)
	{
		services.TryAddSingleton(typeof(ILoggerService<>), typeof(LoggerService<>));

		services.AddLogging(configure =>
		{
			configure.AddEventLog(settings => settings.SourceName = environment.ApplicationName);
#if DEBUG
			configure.SetMinimumLevel(LogLevel.Debug);
#else
			configure.SetMinimumLevel(LogLevel.Warning);
#endif
		});

		return services;
	}
}
