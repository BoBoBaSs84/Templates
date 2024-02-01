using BB84.Notifications;
using BB84.Notifications.Interfaces;

using DomainName.Application.Interfaces.Application.Services;
using DomainName.Application.ViewModels.Base;

namespace DomainName.Application.ViewModels;

/// <summary>
/// The main view model class.
/// </summary>
/// <param name="navigationService">The navigation service instance to use.</param>
public sealed class MainViewModel(INavigationService navigationService) : ViewModelBase
{
	private IRelayCommand? _aboutCommand;
	private IRelayCommand? _exitCommand;

	/// <summary>
	/// The navigation service instance.
	/// </summary>
	public INavigationService NavigationService => navigationService;

	/// <summary>
	/// The command to show the about window.
	/// </summary>
	public IRelayCommand AboutCommand
		=> _aboutCommand ??= new RelayCommand(NavigationService.NavigateTo<AboutViewModel>);

	/// <summary>
	/// The command to exit the application.
	/// </summary>
	public IRelayCommand ExitCommand
		=> _exitCommand ??= new RelayCommand(() => Environment.Exit(0));
}
