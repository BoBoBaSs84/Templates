using DomainName.Domain.Events.Base;

namespace DomainName.Domain.Events.System;

/// <summary>
/// Represents the event data for a tick event.
/// </summary>
/// <param name="source">The source of the event.</param>
public sealed class TickEvent(string source) : EventBase(source)
{ }
