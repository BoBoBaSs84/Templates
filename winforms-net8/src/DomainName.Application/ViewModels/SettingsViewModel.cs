using BB84.Notifications.Commands;
using BB84.Notifications.Interfaces.Commands;

using DomainName.Application.Abstractions.Application.Services;
using DomainName.Application.ViewModels.Base;
using DomainName.Domain.Enumerators;

namespace DomainName.Application.ViewModels;

/// <summary>
/// Represents the view model for application settings, allowing users to configure language
/// preferences and log levels and so.
/// </summary>
public sealed class SettingsViewModel : ViewModelBase
{
	private readonly ISettingsService _settingsService;
	private Language _language = Language.English;
	private LoggingLevel _logLevel = LoggingLevel.Error;
	private IActionCommand<Language>? _changeLanguageCommand;
	private IActionCommand<LoggingLevel>? _changeLogLevelCommand;

	/// <summary>
	/// Initializes a new instance of the <see cref="SettingsViewModel"/> class.
	/// </summary>
	/// <param name="settingsService">The settings service used to manage application settings.</param>
	public SettingsViewModel(ISettingsService settingsService)
	{
		_settingsService = settingsService;
		Language = _settingsService.GetLanguage();
		LogLevel = _settingsService.GetLogLevel();
	}

	/// <summary>
	/// Gets or sets the language preference for the application, allowing users to select their
	/// preferred language from a predefined set of options.
	/// </summary>
	public Language Language
	{
		get => _language;
		set => SetProperty(ref _language, value);
	}

	/// <summary>
	/// Gets or sets the log level preference for the application, allowing users to select their
	/// preferred log level from a predefined set of options.
	/// </summary>
	public LoggingLevel LogLevel
	{
		get => _logLevel;
		set => SetProperty(ref _logLevel, value);
	}

	/// <summary>
	/// The command to change the language preference, which can be bound to UI elements to allow users
	/// the ability to change the application's language settings.
	/// </summary>
	public IActionCommand<Language> ChangeLanguageCommand
		=> _changeLanguageCommand ??= new ActionCommand<Language>(ChangeLanguage, CanChangeLanguage);

	/// <summary>
	/// The command to change the log level preference, which can be bound to UI elements to allow users
	/// the ability to change the application's log level settings.
	/// </summary>
	public IActionCommand<LoggingLevel> ChangeLogLevelCommand
		=> _changeLogLevelCommand ??= new ActionCommand<LoggingLevel>(ChangeLogLevel, CanChangeLogLevel);

	private bool CanChangeLanguage(Language language)
		=> language != _settingsService.GetLanguage();

	private void ChangeLanguage(Language language)
		=> _settingsService.SetLanguage(language);

	private bool CanChangeLogLevel(LoggingLevel logLevel)
		=> logLevel != _settingsService.GetLogLevel();

	private void ChangeLogLevel(LoggingLevel logLevel)
		=> _settingsService.SetLogLevel(logLevel);
}
