using System.Diagnostics.CodeAnalysis;

using DomainName.Application.Interfaces.Application.Providers;
using DomainName.Application.Interfaces.Application.Services;
using DomainName.Application.Providers;
using DomainName.Application.Services;

using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;

using ApplicationConstants = DomainName.Application.Common.Constants;

namespace DomainName.Application.Extensions;

/// <summary>
/// The service collection extensions class.
/// </summary>
[ExcludeFromCodeCoverage(Justification = "Dependency injection helper.")]
[SuppressMessage("Style", "IDE0058", Justification = "Not relevant here, dependency injection.")]
internal static class ServiceCollectionExtensions
{
	/// <summary>
	/// Registers the named http clients to the service collection.
	/// </summary>
	/// <param name="services">The service collection to enrich.</param>
	/// <returns>The enriched service collection.</returns>
	internal static IServiceCollection RegisterHttpClients(this IServiceCollection services)
	{
		services.AddHttpClient(nameof(ApplicationConstants.HttpClient.WikipediaClient), client =>
		{
			client.BaseAddress = new Uri(ApplicationConstants.HttpClient.WikipediaBaseUri);
			client.Timeout = new(0, 0, 15);
			client.DefaultRequestHeaders.Clear();
		});

		return services;
	}

	/// <summary>
	/// Registers the required application providers to the service collection.
	/// </summary>
	/// <param name="services">The service collection to enrich.</param>
	/// <returns>The enriched service collection.</returns>
	internal static IServiceCollection RegisterProviders(this IServiceCollection services)
	{
		services.TryAddSingleton<IDateTimeProvider, DateTimeProvider>();

		return services;
	}

	/// <summary>
	/// Registers the required application services to the service collection.
	/// </summary>
	/// <param name="services">The service collection to enrich.</param>
	/// <returns>The enriched service collection.</returns>
	internal static IServiceCollection RegisterServices(this IServiceCollection services)
	{
		services.TryAddSingleton<IWebService, WebService>();

		return services;
	}
}
