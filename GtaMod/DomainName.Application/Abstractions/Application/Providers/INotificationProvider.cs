using GTA.UI;

namespace DomainName.Application.Abstractions.Application.Providers;

/// <summary>
/// Represents an abstraction contract for the <see cref="Notification"/> class.
/// </summary>
public interface INotificationProvider
{
	/// <inheritdoc cref="Notification.Show(string, bool)"/>
	int Show(string message, bool blinking);

	/// <inheritdoc cref="Notification.Show(NotificationIcon, string, string, string, bool, bool)"/>
	int Show(NotificationIcon icon, string sender, string subject, string message, bool fadeIn, bool blinking);

	/// <inheritdoc cref="Notification.Hide(int)"/>
	void Hide(int handle);
}
