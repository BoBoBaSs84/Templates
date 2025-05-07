﻿namespace DomainName.Application.Abstractions.Application.Providers;

/// <summary>
/// This interface defines a contract for date time provider.
/// </summary>
/// <remarks>
/// Serves as an abstraction for the <see cref="DateTime"/> properties.
/// </remarks>
public interface IDateTimeProvider
{
	/// <inheritdoc cref="DateTime.Now"/>
	public DateTime Now { get; }

	/// <inheritdoc cref="DateTime.TimeOfDay"/>
	public TimeSpan TimeOfDay { get; }

	/// <inheritdoc cref="DateTime.Today"/>
	public DateTime Today { get; }
}
