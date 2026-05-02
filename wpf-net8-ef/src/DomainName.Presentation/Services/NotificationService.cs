using System.Windows;

using DomainName.Application.Abstractions.Presentation.Services;
using DomainName.Application.Enumerators;

using RESX = DomainName.Presentation.Properties.Resources;

namespace DomainName.Presentation.Services;

/// <summary>
/// Represents a service for showing notifications to the user.
/// </summary>
internal sealed class NotificationService : INotificationService
{
	public void ShowError(string message)
		=> ShowMessage(message, RESX.NotificationService_ShowError_Captition, MessageBoxImage.Error);

	public void ShowInformation(string message)
		=> ShowMessage(message, RESX.NotificationService_ShowInformation_Captition, MessageBoxImage.Information);

	public void ShowWarning(string message)
		=> ShowMessage(message, RESX.NotificationService_ShowWarning_Captition, MessageBoxImage.Warning);

	public NotificationResult ShowRetry(string message)
	{
		MessageBoxResult result = ShowQuestion(message, RESX.NotificationService_ShowRetry_Captition, MessageBoxButton.OKCancel);
		return MapMessageBoxResult(result);
	}

	public NotificationResult ShowQuestion(string message)
	{
		MessageBoxResult result = ShowQuestion(message, RESX.NotificationService_ShowQuestion_Captition, MessageBoxButton.YesNo);
		return MapMessageBoxResult(result);
	}

	private static void ShowMessage(string message, string captition, MessageBoxImage icon)
		=> MessageBox.Show(message, captition, MessageBoxButton.OK, icon);

	private static MessageBoxResult ShowQuestion(string message, string captition, MessageBoxButton boxButton)
		=> MessageBox.Show(message, captition, boxButton, MessageBoxImage.Question);

	private static NotificationResult MapMessageBoxResult(MessageBoxResult result)
	{
		return result switch
		{
			MessageBoxResult.None => NotificationResult.None,
			MessageBoxResult.OK => NotificationResult.OK,
			MessageBoxResult.Cancel => NotificationResult.Cancel,
			MessageBoxResult.Yes => NotificationResult.Yes,
			MessageBoxResult.No => NotificationResult.No,
			_ => throw new ArgumentOutOfRangeException(nameof(result), result, null)
		};
	}
}
