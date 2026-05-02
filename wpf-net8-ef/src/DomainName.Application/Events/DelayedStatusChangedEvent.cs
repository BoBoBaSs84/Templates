using BB84.SourceGenerators.Attributes;

namespace DomainName.Application.Events;

/// <summary>
/// Represents an event that is triggered when the status changes and should be cleared after a delay.
/// </summary>
/// <param name="text">The text associated with the status change.</param>
/// <param name="duration">The duration in milliseconds before the status is cleared.</param>
[GenerateToString]
public sealed partial class DelayedStatusChangedEvent(string text, int duration = 2000) : StatusChangedEvent(text, true, duration)
{ }
