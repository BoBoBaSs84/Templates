using DomainName.Events.Base;

namespace DomainName.Events;

/// <summary>
/// Represents an exection event that occurs, when an exception is thrown within the application.
/// </summary>
/// <param name="message">The message of the exception event.</param>
/// <param name="exception">The exception itself, if applyable.</param>
public sealed class ExceptionEvent(string message, Exception? exception) : EventBase
{
	/// <summary>
	/// Gets the message of the exception event.
	/// </summary>
	public string Message { get; } = message;

	/// <summary>
	/// Gets the exception itself, if applyable.
	/// </summary>
	public Exception? Exception { get; } = exception;
}
