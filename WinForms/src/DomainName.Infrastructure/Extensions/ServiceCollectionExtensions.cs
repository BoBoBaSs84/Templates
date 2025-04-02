using System.Diagnostics.CodeAnalysis;

using DomainName.Application.Interfaces.Infrastructure.Services;
using DomainName.Infrastructure.Services;

using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace DomainName.Infrastructure.Extensions;

/// <summary>
/// The infrastructure service collection extensions.
/// </summary>
[ExcludeFromCodeCoverage(Justification = "Dependency injection helper.")]
[SuppressMessage("Style", "IDE0058", Justification = "Not relevant here, dependency injection.")]
internal static class ServiceCollectionExtensions
{
	/// <summary>
	/// Registers the logger service to the service collection.
	/// </summary>
	/// <param name="services">The service collection to enrich.</param>
	/// <param name="environment">The host environment instance to use.</param>
	/// <returns>The enriched service collection.</returns>
	internal static IServiceCollection RegisterLoggerService(this IServiceCollection services, IHostEnvironment environment)
	{
		services.TryAddSingleton(typeof(ILoggerService<>), typeof(LoggerService<>));

		services.AddLogging(config =>
		{
			config.ClearProviders();

			if (environment.IsDevelopment())
			{
				config.SetMinimumLevel(LogLevel.Debug);
				config.AddConsole();
			}

			if (environment.IsProduction())
			{
				config.SetMinimumLevel(LogLevel.Warning);
				config.AddEventLog(config => config.SourceName = environment.ApplicationName);
			}
		});

		return services;
	}
}
