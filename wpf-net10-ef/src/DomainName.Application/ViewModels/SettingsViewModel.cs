using BB84.SourceGenerators.Attributes;

using DomainName.Application.Abstractions.Application.Services;
using DomainName.Application.Abstractions.Application.ViewModels;
using DomainName.Application.Abstractions.Infrastructure.Services;
using DomainName.Application.Abstractions.Services;
using DomainName.Application.Enumerators;
using DomainName.Application.Events;
using DomainName.Application.Settings;
using DomainName.Application.ViewModels.Base;

using Microsoft.Extensions.Logging;

namespace DomainName.Application.ViewModels;

/// <summary>
/// Represents the view model responsible for managing application settings.
/// </summary>
[GenerateNotifications]
public sealed partial class SettingsViewModel : ViewModelBase, INavigatable
{
	private readonly IEventService _eventService;
	private readonly ISettingsService _settingsService;
	private readonly INotificationService _notificationService;
	private readonly ApplicationSettings _applicationSettings;

	/// <summary>
	/// Initializes a new instance of the <see cref="SettingsViewModel"/> class.
	/// </summary>
	/// <param name="eventService">The service responsible for managing application events.</param>
	/// <param name="settingsService">The service responsible for managing application settings.</param>
	/// <param name="notificationService">The service responsible for managing notifications.</param>
	/// <param name="applicationSettings">The current application settings.</param>
	public SettingsViewModel(IEventService eventService, ISettingsService settingsService, INotificationService notificationService, ApplicationSettings applicationSettings)
	{
		_settingsService = settingsService;
		_eventService = eventService;
		_notificationService = notificationService;
		_applicationSettings = applicationSettings;
		_canLoadSettings = true;

		General = _applicationSettings.General;
		General.PropertyChanged += (s, e) => CanSaveSettings = true;
		SelectableLanguages = LanguageExtensions.GetValuesFast();
		SelectableLogLevels = Enum.GetValues<LogLevel>();
	}

	/// <summary>
	/// Gets the general application settings.
	/// </summary>
	public GeneralSettings General { get; }

	/// <summary>
	/// Gets the collection of languages that can be selected for the application.
	/// </summary>
	public IEnumerable<Language> SelectableLanguages { get; }

	/// <summary>
	/// Gets the collection of log levels that can be selected for the application.
	/// </summary>
	public IEnumerable<LogLevel> SelectableLogLevels { get; }

	/// <summary>
	/// Indicates whether the application settings can be loaded.
	/// </summary>
	[NotifyCanExecuteChanged(nameof(LoadSettingsCommand))]
	public partial bool CanLoadSettings { get; private set; }

	/// <summary>
	/// Indicates whether the application settings can be saved.
	/// </summary>
	[NotifyCanExecuteChanged(nameof(SaveSettingsCommand))]
	public partial bool CanSaveSettings { get; private set; }

	[ActionCommand(CanExecute = nameof(CanLoadSettings), ExceptionHandler = nameof(OnError))]
	private async Task LoadSettings(CancellationToken cancellationToken)
	{
		try
		{
			CanLoadSettings = false;

			await _settingsService
				.LoadAsync(cancellationToken);
		}
		finally
		{
			CanLoadSettings = true;
		}
	}

	[ActionCommand(CanExecute = nameof(CanSaveSettings), ExceptionHandler = nameof(OnError))]
	private async Task SaveSettings(CancellationToken cancellationToken)
	{
		try
		{
			CanSaveSettings = false;

			await _settingsService
				.SaveAsync(_applicationSettings, cancellationToken);

			NotificationResult result = _notificationService
				.ShowQuestion("Settings saved successfully. Do you want to restart the application to apply the changes?");

			if (result == NotificationResult.Yes)
				_eventService.Publish(new RestartRequestedEvent());
		}
		finally
		{
			CanSaveSettings = true;
		}
	}

	private void OnError(Exception exception)
	{
		string message = "An error occurred while managing application settings.";
		_eventService.Publish(new DelayedStatusChangedEvent(message));
		_eventService.Publish(new ExceptionOccuredEvent(message, exception));
	}
}
