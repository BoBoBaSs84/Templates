using DomainName.Application.Interfaces.Application.Services;
using DomainName.Application.Services;
using DomainName.Application.ViewModels;
using DomainName.Application.ViewModels.Base;

using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;

namespace DomainName.Application.Extensions;

/// <summary>
/// The service collection extensions class.
/// </summary>
internal static class ServiceCollectionExtensions
{
	/// <summary>
	/// Registers the required view models to the service collection.
	/// </summary>
	/// <param name="services">The service collection to enrich.</param>
	/// <returns>The enriched service collection.</returns>
	internal static IServiceCollection RegisterViewModels(this IServiceCollection services)
	{
		services.TryAddSingleton<MainViewModel>();

		return services;
	}

	/// <summary>
	/// Registers the required navigation service to the service collection.
	/// </summary>
	/// <param name="services">The service collection to enrich.</param>
	/// <returns>The enriched service collection.</returns>
	internal static IServiceCollection RegisterNavigationService(this IServiceCollection services)
	{
		services.TryAddSingleton<INavigationService, NavigationService>();

		services.TryAddSingleton<Func<Type, BaseViewModel>>(serviceProvider
			=> viewModelType => (BaseViewModel)serviceProvider.GetRequiredService(viewModelType));

		return services;
	}
}
