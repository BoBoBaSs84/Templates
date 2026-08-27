using BB84.SourceGenerators.Attributes;

using DomainName.Domain.Events.Base;

namespace DomainName.Application.Events;

/// <summary>
/// Represents an event that is triggered when the status changes.
/// </summary>
/// <param name="text">The text associated with the status change.</param>
[GenerateToString]
public partial class StatusChangedEvent(string text) : EventBase
{
	/// <summary>
	/// Initializes a new instance of the StatusChangedEvent class with the specified status text,
	/// auto-clear option and duration.
	/// </summary>
	/// <param name="text">The status message text.</param>
	/// <param name="autoClear">Should the status automatically clear after the specified duration?</param>
	/// <param name="duration">The duration in milliseconds before the status is cleared.</param>
	public StatusChangedEvent(string text, bool autoClear, int duration) : this(text)
	{
		AutoClear = autoClear;
		Duration = duration;
	}

	/// <summary>
	/// Gets the text associated with the status change.
	/// </summary>
	public string Text { get; } = text;

	/// <summary>
	/// Gets a value indicating whether the status should be automatically cleared after a duration.
	/// </summary>
	public bool AutoClear { get; }

	/// <summary>
	/// Gets the duration in milliseconds after which the status should be cleared if AutoClear is true.
	/// </summary>
	public int Duration { get; }
}
