using DomainName.Application.Interfaces.Presentation.Services;
using DomainName.Presentation.Forms;
using DomainName.Presentation.Services;

using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;

namespace DomainName.Presentation.Extensions;

/// <summary>
/// The presentation service collection extensions.
/// </summary>
internal static class ServiceCollectionExtensions
{
	/// <summary>
	/// Registers the required windows forms to the <paramref name="services"/> collection.
	/// </summary>
	/// <param name="services">The service collection to enrich.</param>
	/// <returns>The enriched service collection.</returns>
	internal static IServiceCollection RegisterForms(this IServiceCollection services)
	{
		services.TryAddSingleton<MainForm>();

		return services;
	}

	/// <summary>
	/// Registers the required services to the <paramref name="services"/> collection.
	/// </summary>
	/// <param name="services">The service collection to enrich.</param>
	/// <returns>The enriched service collection.</returns>
	internal static IServiceCollection RegisterServices(this IServiceCollection services)
	{
		services.TryAddTransient<ICurrentUserService, CurrentUserService>();
		services.TryAddSingleton<INotificationService, NotificationService>();

		return services;
	}
}
