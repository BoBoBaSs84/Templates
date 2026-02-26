using System.Diagnostics.CodeAnalysis;

using DomainName.Application.Abstractions.Presentation.Services;
using DomainName.Presentation.Properties;

namespace DomainName.Presentation.Services;

/// <summary>
/// The notification service class.
/// </summary>
[ExcludeFromCodeCoverage(Justification = "This class is just an abstraction for the MessageBox.")]
internal sealed class NotificationService : INotificationService
{
	public void ShowError(string message)
		=> DisplayMessage(message, Resources.Notification_Error, MessageBoxIcon.Error);

	public void ShowInformation(string message)
		=> DisplayMessage(message, Resources.Notification_Information, MessageBoxIcon.Information);

	public void ShowWarning(string message)
		=> DisplayMessage(message, Resources.Notification_Warning, MessageBoxIcon.Warning);

	public DialogResult ShowQuestion(string message)
		=> DisplayQuestion(message, Resources.Notification_Question, MessageBoxButtons.YesNo, MessageBoxIcon.Question);

	public DialogResult ShowRetry(string message)
		=> MessageBox.Show(message, Resources.Notification_Retry, MessageBoxButtons.RetryCancel, MessageBoxIcon.Question);

	private static void DisplayMessage(string message, string captition, MessageBoxIcon icon)
		=> MessageBox.Show(message, captition, MessageBoxButtons.OK, icon);

	private static DialogResult DisplayQuestion(string message, string captition, MessageBoxButtons messageBoxButtons, MessageBoxIcon icon)
		=> MessageBox.Show(message, captition, messageBoxButtons, icon);
}
