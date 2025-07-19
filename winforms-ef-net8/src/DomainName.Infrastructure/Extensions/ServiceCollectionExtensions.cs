using System.Diagnostics.CodeAnalysis;

using BB84.Extensions;

using DomainName.Application.Abstractions.Infrastructure.Persistence;
using DomainName.Application.Abstractions.Infrastructure.Services;
using DomainName.Infrastructure.Common;
using DomainName.Infrastructure.Persistence;
using DomainName.Infrastructure.Services;

using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace DomainName.Infrastructure.Extensions;

/// <summary>
/// The infrastructure service collection extensions.
/// </summary>
[SuppressMessage("Style", "IDE0058", Justification = "Not relevant here, dependency injection.")]
internal static class ServiceCollectionExtensions
{
	/// <summary>
	/// Registers the database context to the service collection.
	/// </summary>
	/// <param name="services">The service collection to enrich.</param>
	/// <param name="configuration">The configuration instance to use for the connection string.</param>
	/// <param name="environment">The host environment instance to use for logging and error handling.</param>
	/// <returns>The same service collection enriched with the database context.</returns>
	internal static IServiceCollection RegisterDatabaseContext(this IServiceCollection services, IConfiguration configuration, IHostEnvironment environment)
	{
		services.AddDbContext<IDatabaseContext, DatabaseContext>(options =>
		{
			options.UseSqlite(configuration.GetConnectionString("DefaultConnection"), options =>
			{
				options.MigrationsAssembly(typeof(IInfrastructureAssemblyMarker).Assembly.FullName);
				options.CommandTimeout(15);
			});

			if (environment.IsDevelopment())
			{
				options.EnableSensitiveDataLogging();
				options.EnableDetailedErrors();
				options.LogTo(Console.WriteLine, LogLevel.Debug);
			}

			if (environment.IsProduction())
			{
				options.EnableDetailedErrors(false);
				options.EnableSensitiveDataLogging(false);
			}
		}, ServiceLifetime.Singleton);

		return services;
	}

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
				config.AddConsole();

			if (environment.IsProduction())
				config.AddEventLog(config => config.SourceName = environment.ApplicationName);
		});

		return services;
	}

	/// <summary>
	/// Registers the named http clients to the service collection.
	/// </summary>
	/// <param name="services">The service collection to enrich.</param>
	/// <returns>The enriched service collection.</returns>
	internal static IServiceCollection RegisterHttpClients(this IServiceCollection services)
	{
		services.AddHttpClient(Constants.WikiClient.Name, configureClient =>
			configureClient.WithBaseAddress(Constants.WikiClient.BaseUrl)
				.WithMediaType(Constants.WikiClient.MediaType)
				.WithTimeout(TimeSpan.FromSeconds(15)));

		return services;
	}

	/// <summary>
	/// Registers the required infrastructure services to the service collection.
	/// </summary>
	/// <param name="services">The service collection to enrich.</param>
	/// <returns>The enriched service collection.</returns>
	internal static IServiceCollection RegisterServices(this IServiceCollection services)
	{
		services.TryAddSingleton<IProviderService, ProviderService>();
		services.TryAddSingleton<IWebService, WebService>();

		return services;
	}
}
