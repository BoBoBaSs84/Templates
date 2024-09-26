using System.Windows;

using DomainName.Application.Interfaces.Presentation.Services;

namespace DomainName.Presentation.Services;

/// <summary>
/// The notification service class.
/// </summary>
internal sealed class NotificationService : INotificationService
{
	public void SendError(string message)
		=> Send(message, MessageBoxImage.Error);

	public void SendInformation(string message)
		=> Send(message, MessageBoxImage.Information);

	public void SendWarning(string message)
		=> Send(message, MessageBoxImage.Warning);

	private static void Send(string message, MessageBoxImage icon)
		=> MessageBox.Show(message, $"{icon}", MessageBoxButton.OK, icon);
}
