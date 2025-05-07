namespace DomainName.Application.Abstractions.Application.Providers;

/// <summary>
/// The interface for the date time provider.
/// </summary>
public interface IDateTimeProvider
{
	/// <summary>
	/// The current date time.
	/// </summary>
	public DateTime Now { get; }

	/// <summary>
	/// The current time.
	/// </summary>
	public TimeSpan TimeOfDay { get; }

	/// <summary>
	/// The current date.
	/// </summary>
	public DateTime Today { get; }
}
