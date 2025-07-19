using System.Diagnostics.CodeAnalysis;

using DomainName.Application.ViewModels;

using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;

namespace DomainName.Application.Extensions;

/// <summary>
/// The application service collection extensions class.
/// </summary>
[SuppressMessage("Style", "IDE0058", Justification = "Not relevant here, dependency injection.")]
internal static class ServiceCollectionExtensions
{
	/// <summary>
	/// Registers the required application services to the service collection.
	/// </summary>
	/// <param name="services">The service collection to enrich.</param>
	/// <returns>The enriched service collection.</returns>
	internal static IServiceCollection RegisterServices(this IServiceCollection services)
	{

		return services;
	}

	/// <summary>
	/// Registers the required view models to the service collection.
	/// </summary>
	/// <param name="services">The service collection to enrich.</param>
	/// <returns>The enriched service collection.</returns>
	internal static IServiceCollection RegisterViewModels(this IServiceCollection services)
	{
		services.TryAddSingleton<AboutViewModel>();
		services.TryAddSingleton<TodoViewModel>();
		services.TryAddSingleton<MainViewModel>();

		return services;
	}
}
