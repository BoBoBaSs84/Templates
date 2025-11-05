using DomainName.Application.Abstractions.Application.Providers;

using GTA.UI;

namespace DomainName.Application.Providers;

/// <summary>
/// Represents the implementation of the <see cref="INotificationProvider"/> interface.
/// </summary>
internal sealed class NotificationProvider : INotificationProvider
{
	public int Show(string message, bool blinking) => Notification.Show(message, blinking);

	public int Show(NotificationIcon icon, string sender, string subject, string message, bool fadeIn, bool blinking) => Notification.Show(icon, sender, subject, message, fadeIn, blinking);

	public void Hide(int handle) => Notification.Hide(handle);
}
