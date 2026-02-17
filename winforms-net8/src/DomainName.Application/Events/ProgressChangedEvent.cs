using DomainName.Domain.Events.Base;

namespace DomainName.Application.Events;

/// <summary>
/// Represents an event that indicates a change in progress percentage.
/// </summary>
/// <param name="value">The value of progress completed.</param>
public sealed class ProgressChangedEvent(int value) : EventBase
{
	/// <summary>
	/// Initializes a new instance of the <see cref="ProgressChangedEvent"/> class.
	/// </summary>
	/// <param name="value">The value of progress completed.</param>
	/// <param name="minimum">The minimum progress value.</param>
	/// <param name="maximum">The maximum progress value.</param>
	public ProgressChangedEvent(int value, int minimum, int maximum) : this(value)
	{
		Minimum = minimum;
		Maximum = maximum;
	}

	/// <summary>
	/// Gets the value of progress completed.
	/// </summary>
	public int Value => value;

	/// <summary>
	/// Gets the maximum progress value.
	/// </summary>
	public int Maximum { get; } = 100;

	/// <summary>
	/// Gets the minimum progress value.
	/// </summary>
	public int Minimum { get; }
}
