using DomainName.Presentation.Menus.Base;

using GTA;

namespace DomainName.Presentation;

/// <summary>
/// The ui script class.
/// </summary>
[ScriptAttributes(NoDefaultInstance = true)]
public sealed class UI : Script
{
	/// <summary>
	/// Initializes a instance of the ui script class.
	/// </summary>
	public UI()
		=> Tick += OnTick;

	private void OnTick(object sender, EventArgs e)
		=> MenuBase.Processables.Process();
}
