using DomainName.Domain.Events.Base;

namespace DomainName.Domain.Events.Player;

/// <summary>
/// Represents event data for when a player's controllable state changes.
/// </summary>
/// <param name="source">The source of the event.</param>
/// <param name="isControllable">Indicates whether the player is now controllable.</param>
public sealed class ControllableEvent(string source, bool isControllable) : EventBase(source)
{
	/// <summary>
	/// Gets a value indicating whether the player is now controllable.
	/// </summary>
	public bool IsControllable => isControllable;
}
