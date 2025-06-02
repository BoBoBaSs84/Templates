﻿using System.Diagnostics.CodeAnalysis;

using DomainName.Application.Extensions;

using Microsoft.Extensions.DependencyInjection;

namespace DomainName.Application.Installer;

/// <summary>
/// The application dependency injection installer class.
/// </summary>
[SuppressMessage("Style", "IDE0058", Justification = "Not relevant here.")]
public static class DependencyInjectionInstaller
{
	/// <summary>
	/// Registers the application services to the service collection.
	/// </summary>
	/// <param name="services">The service collection to enrich.</param>
	/// <returns>The same service collection instance, so that multiple calls can be chained.</returns>
	public static IServiceCollection RegisterApplicationServices(this IServiceCollection services)
	{
		services.RegisterServices()
			.RegisterViewModels();

		return services;
	}
}
