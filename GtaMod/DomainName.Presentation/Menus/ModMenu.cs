using DomainName.Presentation.Menus.Base;

namespace DomainName.Presentation.Menus;

/// <summary>
/// The mod menu class.
/// </summary>
public sealed class ModMenu : BaseMenu
{
	/// <summary>
	/// Initializes a new instance of the <see cref="ModMenu"/> class.
	/// </summary>
	/// <param name="subtitle">The subtitle of the mod menu.</param>
	/// <param name="description">The description of the mod menu.</param>
	public ModMenu(string subtitle, string description) : base("Main", subtitle, description)
	{ }
}
