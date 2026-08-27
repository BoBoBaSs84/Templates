using System.Diagnostics.CodeAnalysis;

using BB84.Extensions;

using DomainName.Application.Abstractions.Infrastructure.Persistence;
using DomainName.Application.Abstractions.Infrastructure.Services;
using DomainName.Application.Interfaces.Infrastructure.Services;
using DomainName.Application.Settings;
using DomainName.Infrastructure.Common;
using DomainName.Infrastructure.Persistence;
using DomainName.Infrastructure.Persistence.Interceptors;
using DomainName.Infrastructure.Services;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;
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
				builder.SetMinimumLevel(LogLevel.Warning);
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
		services.TryAddScoped<UserAuditSaveChangesInterceptor>();
		services.TryAddScoped<IRepositoryService, RepositoryService>();

		services.AddSingleton<ISettingsService, SettingsService>();
		services.AddSingleton<IWebService, WebService>();

		return services;
	}

	/// <summary>
	/// Registers the repository contex to the service collection.
	/// </summary>
	/// <param name="services">The service collection to enrich.</param>
	/// <param name="environment">The  host environment instance to use.</param>
	/// <returns>The enriched service collection.</returns>
	internal static IServiceCollection RegisterRepositoryContext(this IServiceCollection services, IHostEnvironment environment)
	{
		ApplicationSettings settings = services.BuildServiceProvider()
			.GetRequiredService<ApplicationSettings>();

		services.AddDbContext<IRepositoryContext, RepositoryContext>(options =>
		{
			options.UseSqlServer(settings.Database.GetConnectionString(), options =>
			{
				options.MigrationsHistoryTable(settings.Database.Migration.TableName, settings.Database.Migration.TableSchema);
				options.MigrationsAssembly(typeof(IInfrastructureAssemblyMarker).Assembly.FullName);
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
			else if (environment.IsProduction())
			{
				options.EnableDetailedErrors(false);
				options.EnableSensitiveDataLogging(false);
			}
		});

		return services;
	}
}
