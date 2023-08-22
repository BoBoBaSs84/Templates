using DomainName.Application.Interfaces.Infrastructure.Services;
using DomainName.Infrastructure.Factories;

using GTA;

namespace DomainName;

/// <summary>
/// The main entry point of the modification.
/// </summary>
public sealed class Main : Script
{
	private readonly ILoggerService _logger;

	/// <summary>
	/// Initializes a instance of the main class.
	/// </summary>
	public Main()
	{
		_logger = InfrastructureFactory.GetLoggerService();

		Tick += OnTick;
		Aborted += OnAborted;

		_logger.Information("Starting DomainName ..");
	}

	private void OnAborted(object sender, EventArgs args)
	{
		_logger.Information("Aborting DomainName ..");
	}

	private void OnTick(object sender, EventArgs args)
	{
		// do something every tick
	}
}
