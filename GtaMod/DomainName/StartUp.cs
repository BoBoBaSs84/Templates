using DomainName.Application.Interfaces.Infrastructure.Services;
using DomainName.Infrastructure.Factories;
using DomainName.Presentation.Menus;

using GTA;

namespace DomainName;

/// <summary>
/// The main entry point of the modification.
/// </summary>
[ScriptAttributes(Author = "BoBoBaSs84", SupportURL = "https://github.com/BoBoBaSs84")]
public sealed class StartUp : Script
{
	private readonly ILoggerService _logger;
	private readonly ModMenu _modMenu;

	/// <summary>
	/// Initializes a instance of the main class.
	/// </summary>
	public StartUp()
	{
		_logger = InfrastructureFactory.GetLoggerService();
		_modMenu = new("Mod Menu", "The fancy mod menu.");

		Tick += OnTick;
		Aborted += OnAborted;
		KeyDown += OnKeyDown;
		KeyUp += OnKeyUp;

		_logger.Information("Starting DomainName ..");
	}

	private void OnAborted(object sender, EventArgs e)
	{ }

	private void OnTick(object sender, EventArgs e)
	{ }

	private void OnKeyUp(object sender, KeyEventArgs e)
	{
		if (e.KeyCode == Keys.F10)
			_modMenu.Visible = !_modMenu.Visible;
	}

	private void OnKeyDown(object sender, KeyEventArgs e)
	{ }
}
