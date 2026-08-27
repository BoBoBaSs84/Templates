using System.Diagnostics.CodeAnalysis;

using DomainName.Application.Abstractions.Services;
using DomainName.Application.Installers;
using DomainName.Domain.Installers;
using DomainName.Infrastructure.Installers;
using DomainName.Controls;
using DomainName.Windows;
using DomainName.Services;

using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace DomainName.Extensions;

/// <summary>
/// The service collection extensions class.
/// </summary>
[SuppressMessage("Style", "IDE0058", Justification = "Not relevant here.")]
internal static class ServiceCollectionExtensions
{
	/// <summary>
	/// Registers the required services to the service collection.
	/// </summary>
	/// <param name="services">The service collection to enrich.</param>
	/// <param name="environment">The host environment instance to use.</param>
	/// <returns>The enriched service collection.</returns>
	internal static IServiceCollection RegisterServices(this IServiceCollection services, IHostEnvironment environment)
	{
		services.RegisterApplicationServices();
		services.RegisterDomainServices();
		services.RegisterInfrastructureServices(environment);
		services.RegisterPresentationServices();

		return services;
	}

	/// <summary>
	/// Registers the presentation services to the service collection.
	/// </summary>
	/// <param name="services">The service collection to enrich.</param>
	/// <returns>The enriched service collection.</returns>
	public static IServiceCollection RegisterPresentationServices(this IServiceCollection services)
	{
		services.AddSingleton<IFileDialogService, FileDialogService>();
		services.AddSingleton<INotificationService, NotificationService>();
		services.AddSingleton<IUserService, UserService>();
		services.AddSingleton<AboutControl>();
		services.AddSingleton<MainWindow>();

		return services;
	}
}
