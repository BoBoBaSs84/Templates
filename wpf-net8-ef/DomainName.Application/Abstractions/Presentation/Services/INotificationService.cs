namespace DomainName.Application.Abstractions.Presentation.Services;

/// <summary>
/// The interface for the notification service.
/// </summary>
public interface INotificationService
{
	/// <summary>
	/// Send a informational message.
	/// </summary>
	/// <param name="message">The message to send.</param>
	void SendInformation(string message);

	/// <summary>
	/// Send a warning message.
	/// </summary>
	/// <param name="message">The message to send.</param>
	void SendWarning(string message);

	/// <summary>
	/// Send a error message.
	/// </summary>
	/// <param name="message">The message to send.</param>
	void SendError(string message);
}
