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
	private string _statusBarInfo = string.Empty;

	/// <summary>
	/// The navigation service instance.
	/// </summary>
	public INavigationService NavigationService => navigationService;

	/// <summary>
	/// The status bar information.
	/// </summary>
	public string StatusBarInfo
	{
		get => _statusBarInfo;
		private set => SetProperty(ref _statusBarInfo, value);
	}

	/// <summary>
	/// The command to show the about window.
	/// </summary>
	public IRelayCommand AboutCommand
		=> _aboutCommand ??= new RelayCommand(x => StatusBarInfo = "About was clicked");

	/// <summary>
	/// The command to exit the application.
	/// </summary>
	public IRelayCommand ExitCommand
		=> _exitCommand ??= new RelayCommand(x => Environment.Exit(0));
}
