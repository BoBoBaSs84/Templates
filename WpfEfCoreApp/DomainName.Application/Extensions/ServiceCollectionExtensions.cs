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
		services.TryAddSingleton<AboutViewModel>();
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

		services.TryAddSingleton<Func<Type, ViewModelBase>>(serviceProvider
			=> viewModelType => (ViewModelBase)serviceProvider.GetRequiredService(viewModelType));

		return services;
	}

	/// <summary>
	/// Registers the required singleton services to the service collection.
	/// </summary>
	/// <param name="services">The service collection to enrich.</param>
	/// <returns>The enriched service collection.</returns>
	internal static IServiceCollection RegisterSingletonServices(this IServiceCollection services)
	{
		services.TryAddSingleton<IUserService, UserService>();

		return services;
	}

	/// <summary>
	/// Registers the required scoped services to the service collection.
	/// </summary>
	/// <param name="services">The service collection to enrich.</param>
	/// <returns>The enriched service collection.</returns>
	internal static IServiceCollection RegisterScopedServices(this IServiceCollection services)
	{

		return services;
	}
}
