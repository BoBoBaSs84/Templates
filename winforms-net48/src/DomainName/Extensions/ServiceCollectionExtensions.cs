using System.Diagnostics.CodeAnalysis;

using DomainName.Application.Abstractions.Services;
using DomainName.Application.Installer;
using DomainName.Domain.Installer;
using DomainName.Infrastructure.Installer;
using DomainName.Forms;
using DomainName.Services;

using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Microsoft.Extensions.Hosting;

namespace DomainName.Extensions;

/// <summary>
/// The <see cref="IServiceCollection"/> extensions class.
/// </summary>
[SuppressMessage("Style", "IDE0058", Justification = "Not relevant here, dependency injection.")]
internal static class ServiceCollectionExtensions
{
	/// <summary>
	/// Registers the all the required services to the <paramref name="services"/> collection.
	/// </summary>
	/// <param name="services">The service collection to enrich.</param>
	/// <param name="environment">The host environment instance to use.</param>
	/// <returns>The enriched service collection.</returns>
	internal static IServiceCollection RegisterServices(this IServiceCollection services, IHostEnvironment environment)
	{
		services.RegisterApplicationServices()
			.RegisterDomainServices()
			.RegisterInfrastructureServices(environment)
			.RegisterPresentationServices();

		return services;
	}

	/// <summary>
	/// Registers the presentation services to the <paramref name="services"/> collection.
	/// </summary>
	/// <param name="services">The service collection to enrich.</param>
	/// <returns>The enriched service collection.</returns>
	private static IServiceCollection RegisterPresentationServices(this IServiceCollection services)
	{
		services.RegisterForms()
			.RegisterFactories()
			.RegisterServices();

		return services;
	}

	/// <summary>
	/// Registers the required windows forms to the <paramref name="services"/> collection.
	/// </summary>
	/// <param name="services">The service collection to enrich.</param>
	/// <returns>The enriched service collection.</returns>
	private static IServiceCollection RegisterForms(this IServiceCollection services)
	{
		services.TryAddSingleton<AboutForm>();
		services.TryAddSingleton<MainForm>();

		services.TryAddTransient<FirstForm>();
		services.TryAddTransient<SecondForm>();
		services.TryAddTransient<ThirdForm>();

		return services;
	}

	/// <summary>
	/// Registers the required services to the <paramref name="services"/> collection.
	/// </summary>
	/// <param name="services">The service collection to enrich.</param>
	/// <returns>The enriched service collection.</returns>
	private static IServiceCollection RegisterServices(this IServiceCollection services)
	{
		services.TryAddTransient<IUserService, UserService>();
		services.TryAddSingleton<INavigationService, NavigationService>();
		services.TryAddSingleton<INotificationService, NotificationService>();

		return services;
	}

	/// <summary>
	/// Registers the required factories to the <paramref name="services"/> collection.
	/// </summary>
	/// <param name="services">The service collection to enrich.</param>
	/// <returns>The enriched service collection.</returns>
	private static IServiceCollection RegisterFactories(this IServiceCollection services)
	{
		services.TryAddSingleton<Func<Type, Form>>(serviceProvider
			=> type => (Form)serviceProvider.GetRequiredService(type));

		return services;
	}
}
