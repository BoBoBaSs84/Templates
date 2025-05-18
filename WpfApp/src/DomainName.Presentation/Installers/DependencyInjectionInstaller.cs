﻿using System.Diagnostics.CodeAnalysis;

using DomainName.Presentation.Extensions;

using Microsoft.Extensions.DependencyInjection;

namespace DomainName.Presentation.Installers;

/// <summary>
/// The presentation dependency injection class.
/// </summary>
[SuppressMessage("Style", "IDE0058", Justification = "Not relevant here.")]
public static class DependencyInjectionInstaller
{
	/// <summary>
	/// Registers the presentation services to the service collection.
	/// </summary>
	/// <param name="services">The service collection to enrich.</param>
	/// <returns>The enriched service collection.</returns>
	public static IServiceCollection RegisterPresentationServices(this IServiceCollection services)
	{
		services.RegisterControls()
			.RegisterServices()
			.RegisterWindows();

		return services;
	}
}
