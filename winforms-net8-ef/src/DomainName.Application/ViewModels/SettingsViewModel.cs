using BB84.Notifications.Attributes;
using BB84.Notifications.Commands;
using BB84.Notifications.Interfaces.Commands;

using DomainName.Application.Abstractions.Application.Services;
using DomainName.Application.Enumerators;
using DomainName.Application.Events;
using DomainName.Application.ViewModels.Base;

using Microsoft.Extensions.Logging;

namespace DomainName.Application.ViewModels;

/// <summary>
/// Represents the view model for application settings, allowing users to configure language
/// preferences and log levels and so.
/// </summary>
public sealed class SettingsViewModel : ViewModelBase
{
	private readonly IEventService _eventService;
	private readonly ISettingsService _settingsService;
	private Language _language;
	private LogLevel _logLevel;
	private IActionCommand? _saveCommand;

	/// <summary>
	/// Initializes a new instance of the <see cref="SettingsViewModel"/> class.
	/// </summary>
	/// <param name="eventService">The event service used to publish events when settings are changed.</param>
	/// <param name="settingsService">The settings service used to manage application settings.</param>
	public SettingsViewModel(IEventService eventService, ISettingsService settingsService)
	{
		_eventService = eventService;
		_settingsService = settingsService;

		_language = _settingsService.GetLanguage();
		_logLevel = _settingsService.GetLogLevel();
	}

	/// <summary>
	/// Gets or sets the language preference for the application, allowing users to select their
	/// preferred language from a predefined set of options.
	/// </summary>
	[NotifyChanged(nameof(IsSaveButtonEnabled))]
	public Language Language
	{
		get => _language;
		set => SetProperty(ref _language, value);
	}

	/// <summary>
	/// Gets or sets the log level preference for the application, allowing users to select their
	/// preferred log level from a predefined set of options.
	/// </summary>
	[NotifyChanged(nameof(IsSaveButtonEnabled))]
	public LogLevel LogLevel
	{
		get => _logLevel;
		set => SetProperty(ref _logLevel, value);
	}

	/// <summary>
	/// Indicates whether the settings have been changed from their original values, which can be used
	/// to enable or disable save/apply buttons in the UI.
	/// </summary>
	public bool IsSaveButtonEnabled
		=> _language != _settingsService.GetLanguage() || _logLevel != _settingsService.GetLogLevel();

	/// <summary>
	/// The command to save the current settings, which can be bound to a save/apply button in the UI to
	/// allow users to save their changes.
	/// </summary>
	public IActionCommand SaveCommand
		=> _saveCommand ??= new ActionCommand(SaveSettings);

	private void SaveSettings()
	{
		_settingsService.SetLanguage(_language);
		_settingsService.SetLogLevel(_logLevel);
		RaisePropertiesChanged(nameof(IsSaveButtonEnabled));
		_eventService.Publish(new SettingsChangedEvent());
	}
}
