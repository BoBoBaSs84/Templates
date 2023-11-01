using DomainName.Presentation.Menus.Base;

using GTA;

namespace DomainName.Presentation;

/// <summary>
/// The processables class.
/// </summary>
public sealed class Processables : Script
{
	/// <summary>
	/// Initializes a instance of the processables class.
	/// </summary>
	public Processables()
		=> Tick += (s, e) => MenuBase.Processables.Process();
}
