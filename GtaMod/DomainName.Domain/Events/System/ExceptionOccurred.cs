using DomainName.Domain.Events.Base;

namespace DomainName.Domain.Events.System;

/// <summary>
/// Represents an event that is triggered when an exception occurs in the application.
/// </summary>
/// <param name="exception">The exception that occurred, if available.</param>
public sealed class ExceptionOccurred(Exception? exception) : EventBase
{
	/// <summary>
	/// Gets the exception that occurred, if available.
	/// </summary>
	public Exception? Exception { get; } = exception;
}
