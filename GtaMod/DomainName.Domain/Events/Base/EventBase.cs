namespace DomainName.Domain.Events.Base;

/// <summary>
/// Represents the base event data for all events.
/// </summary>
/// <param name="source">The source of the event.</param>
public abstract class EventBase(string source) : EventArgs
{
	/// <summary>
	/// Gets the source of the event.
	/// </summary>
	public string Source => source;
}
