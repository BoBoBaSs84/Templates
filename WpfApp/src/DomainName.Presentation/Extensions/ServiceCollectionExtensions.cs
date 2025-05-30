﻿using DomainName.Application.Abstractions.Presentation.Services;
using DomainName.Presentation.Controls;
using DomainName.Presentation.Services;
using DomainName.Presentation.Windows;

using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;

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
		services.TryAddSingleton<AboutControl>();

		return services;
	}

	/// <summary>
	/// Registers the required windows to the service collection.
	/// </summary>
	/// <param name="services">The service collection to enrich.</param>
	/// <returns>The enriched service collection.</returns>
	internal static IServiceCollection RegisterWindows(this IServiceCollection services)
	{
		services.TryAddSingleton<MainWindow>();

		return services;
	}

	/// <summary>
	/// Registers the required presentation services to the service collection.
	/// </summary>
	/// <param name="services">The service collection to enrich.</param>
	/// <returns>The enriched service collection.</returns>
	internal static IServiceCollection RegisterServices(this IServiceCollection services)
	{
		services.TryAddSingleton<INotificationService, NotificationService>();
		services.TryAddSingleton<IUserService, UserService>();

		return services;
	}
}
