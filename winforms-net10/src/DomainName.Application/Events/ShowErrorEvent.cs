using DomainName.Domain.Events.Base;

namespace DomainName.Application.Events;

/// <summary>
/// Represents an event that is published when an error message needs to be shown to the user.
/// </summary>
/// <param name="message">The error message to be shown to the user.</param>
public class ShowErrorEvent(string message) : EventBase
{
	/// <summary>
	/// Gets the error message to be shown to the user.
	/// </summary>
	public string Message { get; } = message;
}
