using GTA;

namespace DomainName.Application.Interfaces.Application.Services.Base;

/// <summary>
/// The script service base interface.
/// </summary>
public interface IScriptServiceBase
{
	/// <summary>
	/// An event that is raised when this <see cref="Script"/> gets aborted for any reason.
	/// This should be used for cleaning up anything created during this <see cref="Script"/>.
	/// </summary>
	void OnAborted(object sender, EventArgs e);

	/// <summary>
	/// An event that is raised when a key is first pressed.
	/// The <see cref="KeyEventArgs"/> contains the key that was pressed.
	/// </summary>
	void OnKeyDown(object sender, KeyEventArgs e);

	/// <summary>
	/// An event that is raised when a key is lifted.
	/// The <see cref="KeyEventArgs"/> contains the key that was lifted.
	/// </summary>
	void OnKeyUp(object sender, KeyEventArgs e);

	/// <summary>
	/// An event that is raised every tick of the script.
	/// Put code that needs to be looped each frame in here.
	/// </summary>
	void OnTick(object sender, EventArgs e);
}
