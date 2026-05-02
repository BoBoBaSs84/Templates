using DomainName.Domain.Events.Base;

namespace DomainName.Application.Events;

/// <summary>
/// Represents an event that is triggered when an exception occurs in the application.
/// </summary>
/// <param name="message">The error message of the event.</param>
/// <param name="exception">The exception associated with the error event, if any.</param>
public sealed class ExceptionOccuredEvent(string message, Exception? exception = null) : EventBase
{
	/// <summary>
	/// Gets the error message of the event.
	/// </summary>
	public string Message { get; } = message;

	/// <summary>
	/// Gets the exception associated with the error event, if any.
	/// </summary>
	public Exception? Exception { get; } = exception;
}
