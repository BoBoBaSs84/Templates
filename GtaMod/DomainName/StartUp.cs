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
	private readonly IServiceProvider _serviceProvider;
	private readonly ILoggerService _loggerService;
	private readonly IEventService _eventService;

	/// <summary>
	/// Initializes a new instance of the <see cref="StartUp"/> class.
	/// </summary>
	public StartUp()
	{
		_serviceProvider = CreateServiceProvider();
		_loggerService = _serviceProvider.GetRequiredService<ILoggerService>();
		_eventService = _serviceProvider.GetRequiredService<IEventService>();

		Interval = 10;

		Tick += (s, e) => _eventService.Publish(new TickEvent($"{s}"));
		Aborted += (s, e) => _eventService.Publish(new AbortedEvent($"{s}"));
		KeyDown += (s, e) => _eventService.Publish(new KeyDownEvent($"{s}", e.KeyData));
		KeyUp += (s, e) => _eventService.Publish(new KeyUpEvent($"{s}", e.KeyData));

		_eventService.Subscribe<TickEvent>(e => _loggerService.Debug($"Tick event received: {e.Source}"));
		_eventService.Subscribe<AbortedEvent>(e => _loggerService.Debug($"Aborted event received: {e.Source}"));
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
