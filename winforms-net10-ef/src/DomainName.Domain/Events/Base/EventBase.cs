using DomainName.Domain.Abstractions.Events;

namespace DomainName.Domain.Events.Base;

/// <summary>
/// Represents the base class for all events in the system.
/// </summary>
public abstract class EventBase : IEvent
{
	/// <inheritdoc/>
	public DateTimeOffset OccurredAt { get; } = DateTimeOffset.UtcNow;

	/// <inheritdoc/>
	public Guid Id { get; } = Guid.NewGuid();
}
