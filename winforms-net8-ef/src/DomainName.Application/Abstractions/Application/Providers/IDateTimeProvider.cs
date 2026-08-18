namespace DomainName.Application.Abstractions.Application.Providers;

/// <summary>
/// This interface defines a contract for date time provider.
/// </summary>
/// <remarks>
/// Serves as an abstraction for the <see cref="DateTime"/> properties.
/// </remarks>
public interface IDateTimeProvider
{
	/// <inheritdoc cref="DateTime.Now"/>
	DateTime Now { get; }

	/// <inheritdoc cref="DateTime.UtcNow"/>
	DateTime UtcNow { get; }

	/// <inheritdoc cref="DateTime.TimeOfDay"/>
	TimeSpan TimeOfDay { get; }

	/// <inheritdoc cref="DateTime.Today"/>
	DateTime Today { get; }

	/// <inheritdoc cref="DateTime.MaxValue"/>
	DateTime MaxValue { get; }

	/// <inheritdoc cref="DateTime.MinValue"/>
	DateTime MinValue { get; }
}
