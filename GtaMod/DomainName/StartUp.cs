using DomainName.Application.Abstractions.Application.Services;
using DomainName.Application.Abstractions.Infrastructure.Services;
using DomainName.Application.Installers;
using DomainName.Domain.Events.System;
using DomainName.Infrastructure.Installers;
using DomainName.Presentation.Installers;

using GTA;

using Microsoft.Extensions.DependencyInjection;

namespace DomainName;

/// <summary>
/// The main entry point of the modification.
/// </summary>
[ScriptAttributes(Author = "BoBoBaSs84", SupportURL = "https://github.com/BoBoBaSs84")]
public sealed class StartUp : Script
{
	private readonly IEventService _eventService;
	private readonly ILoggerService _loggerService;

	/// <summary>
	/// Initializes a new instance of the <see cref="StartUp"/> class.
	/// </summary>
	public StartUp()
	{
		ServiceProvider serviceProvider = CreateServiceProvider();
		_eventService = serviceProvider.GetRequiredService<IEventService>();
		_loggerService = serviceProvider.GetRequiredService<ILoggerService>();

		AppDomain.CurrentDomain.UnhandledException += (s, e)
			=> OnUnhandledException(e.ExceptionObject as Exception);

		Interval = 10;

		Tick += (s, e) => _eventService.Publish(new TickTriggered());
		Aborted += (s, e) => _eventService.Publish(new AbortTriggered());
		KeyDown += (s, e) => _eventService.Publish(new KeyPressed(e.KeyData));
		KeyUp += (s, e) => _eventService.Publish(new KeyReleased(e.KeyData));
	}

	private void OnUnhandledException(Exception? exception)
	{
		_loggerService.Critical("An unhandled exception occurred.", exception);
		_eventService.Publish(new ExceptionOccurred(exception));
	}

	/// <summary>
	/// Creates the service provider.
	/// </summary>
	/// <returns>The service provider.</returns>
	private static ServiceProvider CreateServiceProvider()
	{
		IServiceCollection services = new ServiceCollection()
			.AddApplicationServices()
			.AddInfrastructureServices()
			.AddPresentationServices();

		return services.BuildServiceProvider();
	}
}
