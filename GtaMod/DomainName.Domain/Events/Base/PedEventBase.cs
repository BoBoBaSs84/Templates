namespace DomainName.Domain.Events.Base;

/// <summary>
/// Represents the base event data for pedestrian (ped) related events.
/// </summary>
/// <param name="source">The source of the event.</param>
/// <param name="pedId">The unique identifier of the ped.</param>
public abstract class PedEventBase(string source, int pedId) : EventBase(source)
{
	/// <summary>
	/// Gets the unique identifier of the ped.
	/// </summary>
	public int PedId => pedId;
}
