using DomainName.Domain.Events.Base;

namespace DomainName.Application.Events;

/// <summary>
/// Represents an event that is triggered when the status changes.
/// </summary>
/// <param name="text">The text associated with the status change.</param>
public sealed class StatusChangedEvent(string text) : EventBase
{
	/// <summary>
	/// Initializes a new instance of the <see cref="StatusChangedEvent"/> class.
	/// </summary>
	/// <param name="text">The text associated with the status change.</param>
	/// <param name="autoClear">Should the status be automatically cleared?</param>
	/// <param name="duration">After which duration should the status be cleared?</param>
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
	/// Gets a value indicating whether the status should be automatically cleared
	/// after a certain amount of time has passed.
	/// </summary>
	/// <remarks>
	/// The default value is <see langword="true"/>.
	/// </remarks>
	public bool AutoClear { get; } = true;

	/// <summary>
	/// Gets the duration in milliseconds after which the status should be cleared
	/// if AutoClear is set to true.
	/// </summary>
	/// <remarks>
	/// The default value is 2000.
	/// </remarks>
	public int Duration { get; } = 2000;
}
