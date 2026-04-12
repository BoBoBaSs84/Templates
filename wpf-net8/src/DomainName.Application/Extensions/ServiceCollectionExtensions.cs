using System.Diagnostics.CodeAnalysis;

using DomainName.Application.Abstractions.Application.Services;
using DomainName.Application.Services;
using DomainName.Application.ViewModels;
using DomainName.Application.ViewModels.Base;

using Microsoft.Extensions.DependencyInjection;

namespace DomainName.Application.Extensions;

/// <summary>
/// The service collection extensions class.
/// </summary>
[SuppressMessage("Style", "IDE0058", Justification = "Not relevant here, dependency injection.")]
internal static class ServiceCollectionExtensions
{
	/// <summary>
	/// Registers the required application options and settings to the <paramref name="services"/> collection.
	/// </summary>
	/// <param name="services">The service collection to enrich.</param>
	/// <returns>The same <see cref="IServiceCollection"/> so that multiple calls can be chained.</returns>
	internal static IServiceCollection RegisterApplicationOptions(this IServiceCollection services)
	{
		//services.AddOptions<AppSettings>()
		//	.BindConfiguration(nameof(AppSettings))
		//	.ValidateDataAnnotations()
		//	.ValidateOnStart();

		return services;
	}

	/// <summary>
	/// Registers the required application services to the <paramref name="services"/> collection.
	/// </summary>
	/// <param name="services">The service collection to enrich.</param>
	/// <returns>The same <see cref="IServiceCollection"/> so that multiple calls can be chained.</returns>
	internal static IServiceCollection RegisterApplicationServices(this IServiceCollection services)
	{
		services.AddSingleton<INavigationService, NavigationService>();
		services.AddSingleton<Func<Type, ViewModelBase>>(serviceProvider
			=> viewModelType => (ViewModelBase)serviceProvider.GetRequiredService(viewModelType));
		services.AddSingleton<IEventService, EventService>();
		services.AddSingleton<IProviderService, ProviderService>();

		return services;
	}

	/// <summary>
	/// Registers the required view models to the <paramref name="services"/> collection.
	/// </summary>
	/// <param name="services">The service collection to enrich.</param>
	/// <returns>The same <see cref="IServiceCollection"/> so that multiple calls can be chained.</returns>
	internal static IServiceCollection RegisterViewModels(this IServiceCollection services)
	{
		services.AddSingleton<AboutViewModel>();
		services.AddSingleton<MainViewModel>();

		return services;
	}
}
