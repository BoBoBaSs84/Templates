using DomainName.Domain.Events.Base;

namespace DomainName.Domain.Events.System;

/// <summary>
/// Represents the event data for an aborted event.
/// </summary>
/// <param name="source">The source of the event.</param>
public sealed class AbortedEvent(string source) : EventBase(source)
{ }
