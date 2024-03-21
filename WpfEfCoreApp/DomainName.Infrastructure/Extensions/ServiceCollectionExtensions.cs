using System.Diagnostics.CodeAnalysis;

using DomainName.Application.Interfaces.Infrastructure.Services;
using DomainName.Infrastructure.Common;
using DomainName.Infrastructure.Persistence;
using DomainName.Infrastructure.Persistence.Interceptors;
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
	/// Registers the logger service to the service collection.
	/// </summary>
	/// <param name="services">The service collection to enrich.</param>
	/// <param name="environment">The host environment to use.</param>
	/// <returns>The enriched service collection.</returns>
	internal static IServiceCollection RegisterLoggerService(this IServiceCollection services, IHostEnvironment environment)
	{
		services.TryAddSingleton(typeof(ILoggerService<>), typeof(LoggerService<>));

		services.AddLogging(config =>
		{
			config.ClearProviders();
			config.AddEventLog(config => config.SourceName = environment.ApplicationName);

			if (environment.IsDevelopment())
				config.SetMinimumLevel(LogLevel.Debug);

			if (environment.IsProduction())
				config.SetMinimumLevel(LogLevel.Warning);
		});

		return services;
	}

	/// <summary>
	/// Registers the scoped services to the service collection.
	/// </summary>
	/// <param name="services">The service collection to enrich.</param>
	/// <returns>The enriched service collection.</returns>
	internal static IServiceCollection RegisterScopedServices(this IServiceCollection services)
	{
		services.TryAddScoped<CustomSaveChangesInterceptor>();
		services.TryAddScoped<IRepositoryService, RepositoryService>();

		return services;
	}

	/// <summary>
	/// Registers the repository contex to the service collection.
	/// </summary>
	/// <param name="services">The service collection to enrich.</param>
	/// <param name="configuration">The current configuration instance to use.</param>
	/// <param name="environment">The  host environment instance to use.</param>
	/// <returns>The enriched service collection.</returns>
	internal static IServiceCollection RegisterRepositoryContext(this IServiceCollection services, IConfiguration configuration, IHostEnvironment environment)
	{
		services.AddDbContext<RepositoryContext>(options =>
		{
			options.UseSqlServer(configuration.GetConnectionString("SqlServerConnection"), options =>
			{
				options.MigrationsHistoryTable("Migration", "private");
				options.MigrationsAssembly(typeof(IInfrastructureAssemblyMarker).Assembly.FullName);
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
		});

		return services;
	}
}
