using DomainName.Presentation.Menus.Base;

namespace DomainName.Presentation.Menus;

/// <summary>
/// The main menu class.
/// </summary>
public sealed class MainMenu : MenuBase
{
	/// <summary>
	/// Initializes a instance of the main menu class.
	/// </summary>
	/// <param name="subtitle">The subtitle of the menu.</param>
	/// <param name="description">The description of the menu.</param>
	public MainMenu(string subtitle, string description) : base("Main", subtitle, description)
	{ }
}
