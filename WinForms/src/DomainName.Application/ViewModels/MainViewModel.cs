using DomainName.Application.Interfaces.Presentation.Services;
using DomainName.Application.ViewModels.Base;

namespace DomainName.Application.ViewModels;

/// <summary>
/// Represents the main view model of the application.
/// </summary>
/// <param name="currentUserService">The current user service instance to use.</param>
public sealed class MainViewModel(ICurrentUserService currentUserService) : ViewModelBase
{
	/// <summary>
	/// The current user.
	/// </summary>
	public string CurrentUser => $"{currentUserService.UserDomain}\\{currentUserService.UserName}@{currentUserService.MachineName}";
}
