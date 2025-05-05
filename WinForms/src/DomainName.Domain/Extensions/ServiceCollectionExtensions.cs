﻿using System.Diagnostics.CodeAnalysis;

using DomainName.Domain.Models;

using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;

namespace DomainName.Domain.Extensions;

/// <summary>
/// The domain service collection extensions class.
/// </summary>
[ExcludeFromCodeCoverage(Justification = "Dependency injection helper.")]
internal static class ServiceCollectionExtensions
{
	/// <summary>
	/// Registers the required domain models to the service collection.
	/// </summary>
	/// <param name="services">The service collection to enrich.</param>
	/// <returns>The same service collection instance, so that multiple calls can be chained.</returns>
	internal static IServiceCollection RegisterModels(this IServiceCollection services)
	{
		services.TryAddSingleton<AboutModel>();

		return services;
	}
}
