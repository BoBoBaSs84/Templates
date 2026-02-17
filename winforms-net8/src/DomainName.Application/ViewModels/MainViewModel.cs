using BB84.Notifications.Attributes;
using BB84.Notifications.Commands;
using BB84.Notifications.Interfaces.Commands;

using DomainName.Application.Abstractions.Application.Services;
using DomainName.Application.Abstractions.Presentation.Services;
using DomainName.Application.Events;
using DomainName.Application.ViewModels.Base;

using Microsoft.Extensions.Hosting;

namespace DomainName.Application.ViewModels;

/// <summary>
/// Represents the main view model of the application.
/// </summary>
public sealed class MainViewModel : ViewModelBase
{
	#region members

	private readonly IEventService _eventService;
	private readonly IHostEnvironment _hostEnvironment;
	private readonly INotificationService _notificationService;
	private readonly SynchronizationContext? _synchronizationContext;
	private IActionCommand<string>? _changeLanguageCommand;
	private IActionCommand? _exitApplicationCommand;
	private IActionCommand? _openAboutCommand;
	private IActionCommand? _showSettingsCommand;
	private string _applicationTitle;
	private string _statusText;
	private int _progressBarValue;
	private int _progressBarMaximum = 100;
	private int _progressBarMinimum;

	#endregion members

	/// <summary>
	/// Initializes a new instance of the <see cref="MainViewModel"/> class.
	/// </summary>
	/// <param name="eventService">The event service instance to use.</param>
	/// <param name="hostEnvironment">The host environment instance to use.</param>
	/// <param name="notificationService">The notification service instance to use.</param>
	public MainViewModel(IEventService eventService, IHostEnvironment hostEnvironment, INotificationService notificationService)
	{
		_eventService = eventService;
		_hostEnvironment = hostEnvironment;
		_notificationService = notificationService;
		_synchronizationContext = SynchronizationContext.Current;
		_applicationTitle = $"{_hostEnvironment.ApplicationName} - {_hostEnvironment.EnvironmentName}";
		_statusText = string.Empty;

		_eventService.Subscribe<StatusChangedEvent>(OnStatusChanged);
		_eventService.Subscribe<LanguageChangedEvent>(OnLanguageChanged);
		_eventService.Subscribe<ProgressChangedEvent>(OnProgressChanged);
	}

	#region properties

	/// <summary>
	/// The application title for the main window.
	/// </summary>
	public string ApplicationTitle
	{
		get => _applicationTitle;
		private set => SetProperty(ref _applicationTitle, value);
	}

	/// <summary>
	/// Gets or sets the status text for the main window.
	/// </summary>
	public string StatusText
	{
		get => _statusText;
		private set => SetProperty(ref _statusText, value);
	}

	/// <summary>
	/// Gets or sets the value of the progress bar.
	/// </summary>
	[NotifyChanged(nameof(ProgressBarVisible))]
	public int ProgressBarValue
	{
		get => _progressBarValue;
		set => SetProperty(ref _progressBarValue, value);
	}

	/// <summary>
	/// Gets or sets a value indicating whether the progress bar is visible.
	/// </summary>
	public bool ProgressBarVisible
		=> ProgressBarValue > ProgressBarMinimum && ProgressBarValue < ProgressBarMaximum;

	/// <summary>
	/// Gets or sets the maximum value of the progress bar.
	/// </summary>
	[NotifyChanged(nameof(ProgressBarVisible))]
	public int ProgressBarMaximum
	{
		get => _progressBarMaximum;
		set => SetProperty(ref _progressBarMaximum, value);
	}

	/// <summary>
	/// Gets or sets the minimum value of the progress bar.
	/// </summary>
	[NotifyChanged(nameof(ProgressBarVisible))]
	public int ProgressBarMinimum
	{
		get => _progressBarMinimum;
		set => SetProperty(ref _progressBarMinimum, value);
	}

	#endregion properties

	#region commands

	/// <summary>
	/// The command to exit the application.
	/// </summary>
	public IActionCommand ExitApplicationCommand
		=> _exitApplicationCommand ??= new ActionCommand(ExitApplication);

	/// <summary>
	/// The command to change the application language.
	/// </summary>
	public IActionCommand<string> ChangeLanguageCommand
		=> _changeLanguageCommand ??= new ActionCommand<string>(ChangeLanguage);

	/// <summary>
	/// The command to show the about dialog.
	/// </summary>
	public IActionCommand ShowAboutCommand
		=> _openAboutCommand ??= new ActionCommand(ShowAbout);

	/// <summary>
	/// The command to show the settings dialog.
	/// </summary>
	public IActionCommand ShowSettingsCommand
		=> _showSettingsCommand ??= new ActionCommand(ShowSettings);

	#endregion commands

	#region private methods

	private void ExitApplication()
	{
		DialogResult result = _notificationService
			.ShowQuestion("");

		if (result is DialogResult.Yes)
			_eventService.Publish(new ExitApplicationEvent());
	}

	private void ChangeLanguage(string language)
	{
		DialogResult result = _notificationService
			.ShowQuestion("");

		if (result is DialogResult.Yes)
			_eventService.Publish(new ChangeLanguageEvent(language));
	}

	private void ShowAbout()
		=> _eventService.Publish(new ShowAboutEvent());

	private void ShowSettings()
		=> _eventService.Publish(new ShowSettingsEvent());

	private void OnProgressChanged(ProgressChangedEvent @event)
	{
		if (_synchronizationContext is not null)
			_synchronizationContext.Post(_ => ChangeProgress(@event), null);
		else
			ChangeProgress(@event);
	}

	private void ChangeProgress(ProgressChangedEvent @event)
	{
		ProgressBarMinimum = @event.Minimum;
		ProgressBarMaximum = @event.Maximum;
		ProgressBarValue = @event.Value;
	}

	private void OnLanguageChanged(LanguageChangedEvent @event)
	{
		DialogResult result = _notificationService
			.ShowQuestion("");

		if (result is DialogResult.Yes)
			_eventService.Publish(new RestartApplicationEvent());
	}

	private void OnStatusChanged(StatusChangedEvent @event)
	{
		if (_synchronizationContext is not null)
			_synchronizationContext.Post(_ => ChangeStatus(@event), null);
		else
			ChangeStatus(@event);
	}

	private void ChangeStatus(StatusChangedEvent @event)
	{
		StatusText = @event.Text;

		if (@event.AutoClear)
		{
			Task.Delay(@event.Duration)
				.ContinueWith(_ => StatusText = string.Empty);
		}
	}

	#endregion private methods
}
