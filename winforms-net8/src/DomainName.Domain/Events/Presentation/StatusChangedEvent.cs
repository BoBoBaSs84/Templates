using DomainName.Domain.Events.Base;

namespace DomainName.Domain.Events.Presentation;

/// <summary>
/// Represents an event that is triggered when the status changes.
/// </summary>
/// <param name="text">The text associated with the status change.</param>
public sealed class StatusChangedEvent(string text) : EventBase
{
	/// <summary>
	/// Gets the text associated with the status change.
	/// </summary>
	public string Text => text;
}
