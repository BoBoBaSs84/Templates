using DomainName.Application.Interfaces.Application.Services;
using DomainName.Application.ViewModels.Base;

namespace DomainName.Application.ViewModels;

/// <summary>
/// The main view model class.
/// </summary>
/// <param name="navigationService">The navigation service instance to use.</param>
public sealed class MainViewModel(INavigationService navigationService) : ViewModelBase
{
	/// <summary>
	/// The navigation service instance.
	/// </summary>
	public INavigationService NavigationService => navigationService;
}
