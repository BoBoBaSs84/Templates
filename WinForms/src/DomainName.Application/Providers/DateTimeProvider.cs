﻿using System.Diagnostics.CodeAnalysis;

using DomainName.Application.Interfaces.Application.Providers;

namespace DomainName.Application.Providers;

/// <summary>
/// The date time provider class.
/// </summary>
[ExcludeFromCodeCoverage(Justification = "Wrapper class.")]
internal sealed class DateTimeProvider : IDateTimeProvider
{
	/// <inheritdoc/>
	public DateTime Now => DateTime.Now;

	/// <inheritdoc/>
	public TimeSpan TimeOfDay => DateTime.Now.TimeOfDay;

	/// <inheritdoc/>
	public DateTime Today => DateTime.Today;
}
