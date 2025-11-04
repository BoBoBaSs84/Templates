using DomainName.Domain.Events.Base;

namespace DomainName.Domain.Events.System;

/// <summary>
/// Represents the event data for a key down event.
/// </summary>
/// <param name="source">The source of the event.</param>
/// <param name="keyData">The key data associated with the event.</param>
public sealed class KeyDownEvent(string source, Keys keyData) : EventBase(source)
{
	/// <summary>
	/// Gets the key data associated with the event.
	/// </summary>
	public Keys Keys => keyData;
}
