using BB84.Notifications.Commands;
using BB84.Notifications.Interfaces.Commands;

using DomainName.Application.Abstractions.Application.Services;
using DomainName.Application.Abstractions.Application.ViewModels;
using DomainName.Application.Abstractions.Infrastructure.Services;
using DomainName.Application.Abstractions.Presentation.Services;
using DomainName.Application.Enumerators;
using DomainName.Application.Events;
using DomainName.Application.Settings;
using DomainName.Application.ViewModels.Base;

namespace DomainName.Application.ViewModels;

/// <summary>
/// Represents the view model responsible for managing application settings.
/// </summary>
public sealed class SettingsViewModel : ViewModelBase, INavigatable
{
	private readonly IEventService _eventService;
	private readonly ISettingsService _settingsService;
	private readonly INotificationService _notificationService;
	private readonly ApplicationSettings _applicationSettings;
	private bool _canLoadSettings = true;
	private bool _canSaveSettings = true;
	private IAsyncActionCommand? _loadCommand;
	private IAsyncActionCommand? _saveCommand;

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

		General = _applicationSettings.General;
		SupportedLanguages = LanguageExtensions.GetValuesFast();
	}

	/// <summary>
	/// Gets the general application settings.
	/// </summary>
	public GeneralSettings General { get; }

	/// <summary>
	/// Gets the collection of supported languages for the application.
	/// </summary>
	public IEnumerable<Language> SupportedLanguages { get; }

	/// <summary>
	/// Indicates whether the application settings can be loaded.
	/// </summary>
	public bool CanLoadSettings
	{
		get => _canLoadSettings;
		private set => SetProperty(ref _canLoadSettings, value);
	}

	/// <summary>
	/// Indicates whether the application settings can be saved.
	/// </summary>
	public bool CanSaveSettings
	{
		get => _canSaveSettings;
		private set => SetProperty(ref _canSaveSettings, value);
	}

	/// <summary>
	/// Gets the command to load the application settings.
	/// </summary>
	public IAsyncActionCommand LoadCommand
		=> _loadCommand ??= new AsyncActionCommand(LoadSettings, () => CanLoadSettings, OnError);

	/// <summary>
	/// Gets the command to save the application settings.
	/// </summary>
	public IAsyncActionCommand SaveCommand
		=> _saveCommand ??= new AsyncActionCommand(SaveSettings, () => CanSaveSettings, OnError);

	private async Task LoadSettings()
	{
		try
		{
			CanLoadSettings = false;

			await _settingsService
				.LoadAsync()
				.ConfigureAwait(false);
		}
		finally
		{
			CanLoadSettings = true;
		}
	}

	private async Task SaveSettings()
	{
		try
		{
			CanSaveSettings = false;

			await _settingsService
				.SaveAsync(_applicationSettings)
				.ConfigureAwait(false);

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
