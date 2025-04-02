using DomainName.Application.Interfaces.Presentation.Services;

namespace DomainName.Presentation.Services;

/// <summary>
/// The notification service class.
/// </summary>
internal sealed class NotificationService : INotificationService
{
	public void SendError(string message)
		=> Send(message, "Error", MessageBoxIcon.Error);

	public void SendInformation(string message)
		=> Send(message, "Information", MessageBoxIcon.Information);

	public void SendWarning(string message)
		=> Send(message, "Warning", MessageBoxIcon.Warning);

	private static void Send(string message, string captition, MessageBoxIcon icon)
		=> MessageBox.Show(message, captition, MessageBoxButtons.OK, icon);
}
