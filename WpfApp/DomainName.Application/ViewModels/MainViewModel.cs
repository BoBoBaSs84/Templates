﻿using BB84.Notifications.Commands;
using BB84.Notifications.Interfaces.Commands;

using DomainName.Application.Interfaces.Application.Services;
using DomainName.Application.ViewModels.Base;

namespace DomainName.Application.ViewModels;

/// <summary>
/// The main view model class.
/// </summary>
/// <param name="navigationService">The navigation service instance to use.</param>
public sealed class MainViewModel(INavigationService navigationService) : ViewModelBase
{
	private IActionCommand? _aboutCommand;
	private IActionCommand? _exitCommand;

	/// <summary>
	/// The navigation service instance.
	/// </summary>
	public INavigationService NavigationService => navigationService;

	/// <summary>
	/// The command to show the about control.
	/// </summary>
	public IActionCommand AboutCommand
		=> _aboutCommand ??= new ActionCommand(NavigationService.NavigateTo<AboutViewModel>);

	/// <summary>
	/// The command to exit the application.
	/// </summary>
	public IActionCommand ExitCommand
		=> _exitCommand ??= new ActionCommand(() => Environment.Exit(0));
}
