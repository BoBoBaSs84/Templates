namespace DomainName.Domain.Events.Base;

/// <summary>
/// Represents the base class for all events in the system.
/// </summary>
public abstract class EventBase
{
	/// <summary>
	/// Initializes a new instance of the <see cref="EventBase"/> class.
	/// </summary>
	protected EventBase()
		=> Id = Guid.NewGuid();

	/// <summary>
	/// Gets the unique identifier of the event.
	/// </summary>
	public Guid Id { get; }
}
