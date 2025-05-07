using System.Diagnostics.CodeAnalysis;

using DomainName.Application.Abstractions.Application.Providers;

namespace DomainName.Application.Providers;

/// <summary>
/// The implementation for the date time provider contract.
/// </summary>
[ExcludeFromCodeCoverage(Justification = "This class is a simple wrapper around the System.DateTime class.")]
internal sealed class DateTimeProvider : IDateTimeProvider
{
	public DateTime Now => DateTime.Now;

	public TimeSpan TimeOfDay => DateTime.Now.TimeOfDay;

	public DateTime Today => DateTime.Today;
}
