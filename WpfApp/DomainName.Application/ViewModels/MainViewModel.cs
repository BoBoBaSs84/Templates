using BB84.Notifications;
using BB84.Notifications.Interfaces;

using DomainName.Application.Interfaces.Application.Services;
using DomainName.Application.ViewModels.Base;

namespace DomainName.Application.ViewModels;

/// <summary>
/// The main view model class.
/// </summary>
/// <param name="navigationService">The navigation service instance to use.</param>
public sealed class MainViewModel(INavigationService navigationService) : BaseViewModel
{
	private IRelayCommand? _aboutCommand;
	private IRelayCommand? _exitCommand;

	/// <summary>
	/// The navigation service instance.
	/// </summary>
	public INavigationService NavigationService
	{
		get => navigationService;
		set => SetProperty(ref navigationService, value);
	}

	/// <summary>
	/// The command to show the about window.
	/// </summary>
	public IRelayCommand AboutCommand
		=> _aboutCommand ??= new RelayCommand(x => Environment.Exit(1));

	/// <summary>
	/// The command to exit the application.
	/// </summary>
	public IRelayCommand ExitCommand
		=> _exitCommand ??= new RelayCommand(x => Environment.Exit(0));
}
