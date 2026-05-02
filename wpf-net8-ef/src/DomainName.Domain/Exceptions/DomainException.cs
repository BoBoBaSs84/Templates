namespace DomainName.Domain.Exceptions;

/// <summary>
/// Represents errors that occur during application execution related to domain logic.
/// </summary>
public sealed class DomainException : Exception
{
	/// <summary>
	/// Initializes a new instance of the <see cref="DomainException"/> class with a specified error message.
	/// </summary>
	/// <param name="message">The error message that explains the reason for the exception.</param>
	public DomainException(string message) : base(message) { }

	/// <summary>
	/// Initializes a new instance of the <see cref="DomainException"/> class with a specified error message
	/// and a reference to the inner exception that is the cause of this exception.
	/// </summary>
	/// <param name="message">The error message that explains the reason for the exception.</param>
	/// <param name="innerException">The exception that is the cause of the current exception.</param>
	public DomainException(string message, Exception innerException) : base(message, innerException) { }
}
