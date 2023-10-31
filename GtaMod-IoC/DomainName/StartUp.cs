using DomainName.Application.Installers;
using DomainName.Application.Interfaces.Application.Services;
using DomainName.Application.Interfaces.Infrastructure.Services;
using DomainName.Infrastructure.Installers;

using GTA;

using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace DomainName;

/// <summary>
/// The main entry point of the modification.
/// </summary>
[ScriptAttributes(Author = "BoBoBaSs84", SupportURL = "https://github.com/BoBoBaSs84")]
public sealed class StartUp : Script
{
	private readonly ILoggerService _loggerService;
	private readonly IServiceProvider _serviceProvider;

	/// <summary>
	/// Initializes a instance of the main class.
	/// </summary>
	public StartUp()
	{
		IHost host = CreateHost();
		_serviceProvider = host.Services;
		_loggerService = GetRequiredService<ILoggerService>();
		_loggerService.Information("Host started.");

		IMainScript mainScript = GetRequiredService<IMainScript>();

		Tick += mainScript.OnTick;
		Aborted += mainScript.OnAborted;
		KeyDown += mainScript.OnKeyDown;
		KeyUp += mainScript.OnKeyUp;
	}

	/// <summary>
	/// Returns the requested service if it is registered within the service collection.
	/// </summary>
	/// <typeparam name="T">The type of service we are operating on.</typeparam>
	/// <returns>The requested service.</returns>
	/// <exception cref="ArgumentException"></exception>
	public T GetRequiredService<T>()
		=> _serviceProvider?.GetRequiredService(typeof(T)) is not T service
		? throw new ArgumentException($"{typeof(T)} needs to be a registered service.")
		: service;

	private static IHost CreateHost()
	{
		IHostBuilder builder = Host.CreateDefaultBuilder()
			.ConfigureServices((context, services) =>
			{
				_ = services.AddApplicationServices();
				_ = services.AddInfrastructureServices();
			});

		return builder.Start();
	}
}
