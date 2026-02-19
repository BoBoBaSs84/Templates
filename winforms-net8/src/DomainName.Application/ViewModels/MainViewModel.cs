using BB84.Notifications.Attributes;
using BB84.Notifications.Commands;
using BB84.Notifications.Interfaces.Commands;

using DomainName.Application.Abstractions.Application.Services;
using DomainName.Application.Abstractions.Presentation.Services;
using DomainName.Application.Events;
using DomainName.Application.Properties;
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
	private ActionCommand? _exitApplicationCommand;
	private ActionCommand? _showAboutCommand;
	private ActionCommand? _showOpenFileCommand;
	private ActionCommand? _showSaveFileCommand;
	private ActionCommand? _showSettingsCommand;
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

		_eventService.Subscribe<FileOpenedEvent>(OnFileOpened);
		_eventService.Subscribe<FileSavedEvent>(OnFileSaved);
		_eventService.Subscribe<StatusChangedEvent>(OnStatusChanged);
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
	/// The command to show the about dialog.
	/// </summary>
	public IActionCommand ShowAboutCommand
		=> _showAboutCommand ??= new ActionCommand(ShowAbout);

	/// <summary>
	/// The command to show the open file dialog.
	/// </summary>
	public IActionCommand ShowOpenFileCommand
		=> _showOpenFileCommand ??= new ActionCommand(ShowOpenFile);

	/// <summary>
	/// The command to show the save file dialog.
	/// </summary>
	public IActionCommand ShowSaveFileCommand
		=> _showSaveFileCommand ??= new ActionCommand(ShowSaveFile);

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
			.ShowQuestion(Resources.ViewModel_Question_ExitApplication);

		if (result is DialogResult.Yes)
			_eventService.Publish(new ExitApplicationEvent());
	}

	private void ShowAbout()
		=> _eventService.Publish(new ShowAboutEvent());

	private void ShowOpenFile()
		=> _eventService.Publish(new ShowOpenFileEvent());

	/// <summary>
	/// Dummy implementation to show the save file dialog.
	/// In a real application, you would pass the actual file content to save.
	/// </summary>
	private void ShowSaveFile()
		=> _eventService.Publish(new ShowSaveFileEvent([66, 66, 66]));

	private void ShowSettings()
		=> _eventService.Publish(new ShowSettingsEvent());

	private void OnFileSaved(FileSavedEvent @event)
	{
		string message = "File saved successfully: " + @event.FilePath;
		_eventService.Publish(new StatusChangedEvent(message));
	}

	private void OnFileOpened(FileOpenedEvent @event)
	{
		string message = "File opened successfully. Size: " + @event.FileContent.Length + " bytes.";
		_eventService.Publish(new StatusChangedEvent(message));
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
		ProgressBarMinimum = @event.Minimum;
		ProgressBarMaximum = @event.Maximum;
		ProgressBarValue = @event.Value;
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
