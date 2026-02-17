using Microsoft.Extensions.DependencyInjection;

namespace DomainName.Domain.Extensions;

/// <summary>
/// The domain service collection extensions class.
/// </summary>
internal static class ServiceCollectionExtensions
{
	/// <summary>
	/// Registers the required domain models to the service collection.
	/// </summary>
	/// <param name="services">The service collection to enrich.</param>
	/// <returns>The same service collection instance, so that multiple calls can be chained.</returns>
	internal static IServiceCollection RegisterModels(this IServiceCollection services)
	{

		return services;
	}
}
