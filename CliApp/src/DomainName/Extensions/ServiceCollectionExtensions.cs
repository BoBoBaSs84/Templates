using System.Diagnostics.CodeAnalysis;

using DomainName.Abstractions.Services;
using DomainName.Options;
using DomainName.Services;

using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace DomainName.Extensions;

/// <summary>
/// The service collection extensions class.
/// </summary>
[SuppressMessage("Style", "IDE0058", Justification = "Not relevant here, dependency injection.")]
internal static class ServiceCollectionExtensions
{
	/// <summary>
	/// Registers the application services to the service collection.
	/// </summary>
	/// <param name="services">The service collection to enrich.</param>
	/// <param name="environment">The host environment instance to use.</param>
	/// <returns>
	/// The same <see cref="IServiceCollection"/> instance so that multiple calls can be chained.
	/// </returns>	
	internal static IServiceCollection RegisterServices(this IServiceCollection services, IHostEnvironment environment)
	{
		services.RegisterLoggerService(environment);

		WeatherForecastOption.Bind(services);

		services.AddSingleton<IEventService, EventService>();
		services.AddSingleton<IWeatherForecastService, WeatherForecastService>();

		return services;
	}

	/// <summary>
	/// Registers the logger service.
	/// </summary>
	/// <param name="services">The service collection to enrich.</param>
	/// <param name="environment">The host environment instance to use.</param>
	/// <returns>
	/// The same <see cref="IServiceCollection"/> instance so that multiple calls can be chained.
	/// </returns>	
	[SuppressMessage("Interoperability", "CA1416", Justification = "Validate platform compatibility done.")]
	private static IServiceCollection RegisterLoggerService(this IServiceCollection services, IHostEnvironment environment)
	{
		services.AddSingleton(typeof(ILoggerService<>), typeof(LoggerService<>));

		services.AddLogging(builder =>
		{
			builder.ClearProviders();

			if (environment.IsDevelopment())
			{
				builder.SetMinimumLevel(LogLevel.Debug);
				builder.AddConsole();
			}

			if (environment.IsProduction())
			{
				builder.SetMinimumLevel(LogLevel.Warning);
				builder.AddEventLog(settings => settings.SourceName = environment.ApplicationName);
			}
		});

		return services;
	}
}
