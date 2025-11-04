namespace DomainName.Domain.Events.System;

/// <summary>
/// Represents the event data for a key down event.
/// </summary>
/// <param name="source">The source of the event.</param>
/// <param name="keyData">The key data associated with the event.</param>
public sealed class KeyDownEvent(string source, Keys keyData) : KeyEventArgs(keyData)
{
	/// <summary>
	/// Gets the sender of the event.
	/// </summary>
	public string Sender => source;
}
