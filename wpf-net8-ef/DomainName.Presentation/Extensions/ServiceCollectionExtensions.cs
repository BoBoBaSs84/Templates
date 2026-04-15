using DomainName.Application.Abstractions.Presentation.Services;
using DomainName.Presentation.Controls;
using DomainName.Presentation.Services;
using DomainName.Presentation.Windows;

using Microsoft.Extensions.DependencyInjection;

namespace DomainName.Presentation.Extensions;

/// <summary>
/// The presentation service collection extensions.
/// </summary>
internal static class ServiceCollectionExtensions
{
	/// <summary>
	/// Registers the required controls to the service collection.
	/// </summary>
	/// <param name="services">The service collection to enrich.</param>
	/// <returns>The enriched service collection.</returns>
	internal static IServiceCollection RegisterControls(this IServiceCollection services)
	{
		services.AddSingleton<AboutControl>();

		return services;
	}

	/// <summary>
	/// Registers the required presentation services to the service collection.
	/// </summary>
	/// <param name="services">The service collection to enrich.</param>
	/// <returns>The enriched service collection.</returns>
	internal static IServiceCollection RegisterServices(this IServiceCollection services)
	{
		services.AddSingleton<INotificationService, NotificationService>();
		services.AddTransient<IUserService, UserService>();

		return services;
	}

	/// <summary>
	/// Registers the required windows to the service collection.
	/// </summary>
	/// <param name="services">The service collection to enrich.</param>
	/// <returns>The enriched service collection.</returns>
	internal static IServiceCollection RegisterWindows(this IServiceCollection services)
	{
		services.AddSingleton<MainWindow>();

		return services;
	}
}
