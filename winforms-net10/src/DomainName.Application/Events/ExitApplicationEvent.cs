using DomainName.Domain.Events.Base;

namespace DomainName.Application.Events;

/// <summary>
/// Represents an event that is published when the application is exiting, allowing subscribers
/// to perform any necessary cleanup or finalization tasks before the application shuts down.
/// </summary>
public sealed class ExitApplicationEvent : EventBase
{ }
