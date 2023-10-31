using DomainName.Application.Interfaces.Application.Services;
using DomainName.Application.Interfaces.Infrastructure.Services;

namespace DomainName.Application.Services;

/// <summary>
/// The main script class.
/// </summary>
public sealed class MainScript : IMainScript
{
	private readonly ILoggerService _loggerService;

	/// <summary>
	/// Initializes a instance of the main script class.
	/// </summary>
	/// <param name="loggerService">The logger service to use.</param>
	public MainScript(ILoggerService loggerService)
	{
		_loggerService = loggerService;
		
		_loggerService.Information("main script started ..");
	}

	/// <inheritdoc/>
	public void OnAborted(object sender, EventArgs e)
	{	}

	/// <inheritdoc/>
	public void OnKeyDown(object sender, KeyEventArgs e)
	{	}

	/// <inheritdoc/>
	public void OnKeyUp(object sender, KeyEventArgs e)
	{	}

	/// <inheritdoc/>
	public void OnTick(object sender, EventArgs e)
	{	}
}
