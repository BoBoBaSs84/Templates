using BB84.Notifications;

using DomainName.Application.Interfaces.Presentation.Services;

namespace DomainName.Application.ViewModels;

/// <summary>
/// Represents the main view model of the application.
/// </summary>
/// <param name="currentUserService">The current user service instance to use.</param>
public sealed class MainViewModel(ICurrentUserService currentUserService) : NotifiableObject
{
	/// <summary>
	/// The current user.
	/// </summary>
	public string User => $"{currentUserService.UserDomainName}\\{currentUserService.UserName}@{currentUserService.MachineName}";
}
