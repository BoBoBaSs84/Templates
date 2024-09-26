using System.Windows;

using DomainName.Application.Interfaces.Presentation.Services;

namespace DomainName.Presentation.Services;

/// <summary>
/// The notification service class.
/// </summary>
internal sealed class NotificationService : INotificationService
{
	public void SendError(string message)
		=> Send(message, "Error", MessageBoxImage.Error);

	public void SendInformation(string message)
		=> Send(message, "Information", MessageBoxImage.Information);

	public void SendWarning(string message)
		=> Send(message, "Warning", MessageBoxImage.Warning);

	private static void Send(string message, string captition, MessageBoxImage icon)
		=> MessageBox.Show(message, captition, MessageBoxButton.OK, icon);
}
