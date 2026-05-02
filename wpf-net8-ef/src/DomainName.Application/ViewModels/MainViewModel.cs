using BB84.Notifications.Commands;
using BB84.Notifications.Interfaces.Commands;

using DomainName.Application.Abstractions.Application.Services;
using DomainName.Application.Abstractions.Presentation.Services;
using DomainName.Application.Enumerators;
using DomainName.Application.Events;
using DomainName.Application.ViewModels.Base;

using Microsoft.Extensions.Hosting;

using RESX = DomainName.Application.Properties.Resources;

namespace DomainName.Application.ViewModels;

/// <summary>
/// The main view model class.
/// </summary>
public sealed class MainViewModel : ViewModelBase
{
	private readonly IEventService _eventService;
	private readonly INotificationService _notificationService;
	private readonly SynchronizationContext? _synchronizationContext;
	private ActionCommand? _showAboutCommand;
	private ActionCommand? _exitApplicationCommand;
	private ActionCommand? _showSettingsCommand;
	private string _applicationTitle;
	private string _applicationStatus;
	private int _progressBarValue;
	private bool _progressBarVisible;
	private int _progressBarMaximum = 100;
	private int _progressBarMinimum;

	/// <summary>
	/// Initializes a new instance of the <see cref="MainViewModel"/> class.
	/// </summary>
	/// <param name="eventService">The event service for subscribing to application events.</param>
	/// <param name="hostEnvironment">The host environment instance to use.</param>
	/// <param name="navigationService">The navigation service instance to use.</param>
	/// <param name="notificationService">The notification service instance to use.</param>
	public MainViewModel(IEventService eventService, IHostEnvironment hostEnvironment, INavigationService navigationService, INotificationService notificationService)
	{
		_eventService = eventService;
		_notificationService = notificationService;
		_synchronizationContext = SynchronizationContext.Current;
		_applicationTitle = $"{hostEnvironment.ApplicationName} - {hostEnvironment.EnvironmentName}";
		_applicationStatus = string.Empty;

		NavigationService = navigationService;

		_eventService.Subscribe<DelayedStatusChangedEvent>(OnStatusChanged);
		_eventService.Subscribe<ProgressChangedEvent>(OnProgressChanged);
	}

	/// <summary>
	/// Gets or sets the title of the application.
	/// </summary>
	public string ApplicationTitle
	{
		get => _applicationTitle;
		private set => SetProperty(ref _applicationTitle, value);
	}

	/// <summary>
	/// Gets or sets the current status of the application.
	/// </summary>
	public string ApplicationStatus
	{
		get => _applicationStatus;
		private set => SetProperty(ref _applicationStatus, value);
	}

	/// <summary>
	/// Gets or sets the value of the progress bar.
	/// </summary>
	public int ProgressBarValue
	{
		get => _progressBarValue;
		set => SetProperty(ref _progressBarValue, value);
	}

	/// <summary>
	/// Gets or sets a value indicating whether the progress bar is visible.
	/// </summary>
	public bool ProgressBarVisible
	{
		get => _progressBarVisible;
		set => SetProperty(ref _progressBarVisible, value);
	}

	/// <summary>
	/// Gets or sets the maximum value of the progress bar.
	/// </summary>
	public int ProgressBarMaximum
	{
		get => _progressBarMaximum;
		set => SetProperty(ref _progressBarMaximum, value);
	}

	/// <summary>
	/// Gets or sets the minimum value of the progress bar.
	/// </summary>
	public int ProgressBarMinimum
	{
		get => _progressBarMinimum;
		set => SetProperty(ref _progressBarMinimum, value);
	}

	/// <summary>
	/// Gets the navigation service instance.
	/// </summary>
	public INavigationService NavigationService { get; }

	/// <summary>
	/// The command to show the about control.
	/// </summary>
	public IActionCommand ShowAboutCommand
		=> _showAboutCommand ??= new ActionCommand(ShowAbout);

	/// <summary>
	/// The command to show the settings control.
	/// </summary>
	public IActionCommand ShowSettingsCommand
		=> _showSettingsCommand ??= new ActionCommand(ShowSettings);

	/// <summary>
	/// The command to exit the application.
	/// </summary>
	public IActionCommand ExitApplicationCommand
		=> _exitApplicationCommand ??= new ActionCommand(ExitApplication);

	private void ShowAbout()
		=> NavigationService.NavigateTo<AboutViewModel>();

	private void ShowSettings()
		=> NavigationService.NavigateTo<SettingsViewModel>();

	private void ExitApplication()
	{
		NotificationResult result = _notificationService
			.ShowQuestion(RESX.MainViewModel_Notification_QuitApplication);

		if (result == NotificationResult.Yes)
			_eventService.Publish(new ExitRequestedEvent());
	}

	private void OnStatusChanged(DelayedStatusChangedEvent @event)
	{
		if (_synchronizationContext is not null)
			_synchronizationContext.Post(_ => ChangeStatus(@event), null);
		else
			ChangeStatus(@event);
	}

	private void ChangeStatus(DelayedStatusChangedEvent @event)
	{
		ApplicationStatus = @event.Text;

		if (@event.AutoClear)
		{
			Task.Delay(@event.Duration)
				.ContinueWith(_ => ApplicationStatus = string.Empty);
		}
	}

	private void OnProgressChanged(ProgressChangedEvent @event)
	{
		if (_synchronizationContext is not null)
			_synchronizationContext.Post(_ => ChangeProgress(@event), null);
		else
			ChangeProgress(@event);
	}

	private void ChangeProgress(ProgressChangedEvent @event)
	{
		ProgressBarMaximum = @event.Maximum;
		ProgressBarMinimum = @event.Minimum;
		ProgressBarValue = @event.Value;
		ProgressBarVisible = @event.Value is > 0 and < 100;
	}
}
