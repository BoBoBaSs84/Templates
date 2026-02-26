using System.Diagnostics.CodeAnalysis;

using BB84.Extensions;

using DomainName.Application.Abstractions.Application.Services;
using DomainName.Application.Abstractions.Infrastructure.Persistence;
using DomainName.Application.Abstractions.Infrastructure.Services;
using DomainName.Infrastructure.Common;
using DomainName.Infrastructure.Persistence;
using DomainName.Infrastructure.Services;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;
using Microsoft.Extensions.DependencyInjection;
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
	/// <param name="environment">The host environment instance to use for logging and error handling.</param>
	/// <returns>The same service collection enriched with the database context.</returns>
	internal static IServiceCollection RegisterDatabaseContext(this IServiceCollection services, IHostEnvironment environment)
	{
		services.AddDbContext<IDatabaseContext, DatabaseContext>(options =>
		{
			string databaseConnection = services
			.BuildServiceProvider()
			.GetRequiredService<ISettingsService>()
			.GetDatabaseConnection();

			options.UseSqlite(databaseConnection, options =>
			{
				options.MigrationsAssembly(typeof(IInfrastructureAssemblyMarker).Assembly.FullName);
				options.CommandTimeout(15);
			})
			.ConfigureWarnings(warnings =>
			{
				warnings.Ignore(CoreEventId.InvalidIncludePathError);
				warnings.Log([(RelationalEventId.CommandExecuted, LogLevel.Debug)]);
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

	/// <summary>
	/// Registers the logger service to the service collection.
	/// </summary>
	/// <param name="services">The service collection to enrich.</param>
	/// <param name="environment">The host environment instance to use.</param>
	/// <returns>The enriched service collection.</returns>
	internal static IServiceCollection RegisterLoggerService(this IServiceCollection services, IHostEnvironment environment)
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
				LogLevel logLevel = services.BuildServiceProvider()
					.GetRequiredService<ISettingsService>()
					.GetLogLevel();

				builder.SetMinimumLevel(logLevel);
				builder.AddEventLog(settings => settings.SourceName = environment.ApplicationName);
			}
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
		services.AddSingleton<IFileStorageService, FileStorageService>();
		services.AddScoped<IRepositoryService, RepositoryService>();
		services.AddSingleton<IProviderService, ProviderService>();
		services.AddSingleton<IWebService, WebService>();

		return services;
	}
}
