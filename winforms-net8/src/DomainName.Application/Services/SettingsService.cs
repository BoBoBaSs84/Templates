using System.Configuration;

using DomainName.Application.Abstractions.Application.Services;
using DomainName.Application.Events;
using DomainName.Domain.Enumerators;

namespace DomainName.Application.Services;

/// <summary>
/// Represents a service responsible for managing application settings, such as user preferences,
/// configuration options, and other customizable parameters.
/// </summary>
/// <param name="eventService">The event service instance to use for publishing and subscribing events.</param>
internal sealed class SettingsService(IEventService eventService) : ISettingsService
{
	private const string AppSettingsSection = "appSettings";
	private const string LanguageSettingKey = "language";
	private const string LogLevelSettingKey = "logLevel";
	private readonly Configuration _configuration = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);

	public Language GetLanguage()
	{
		string languageValue = _configuration.AppSettings.Settings[LanguageSettingKey].Value;
		if (Enum.TryParse(languageValue, out Language language))
			return language;
		return Language.English; // Default
	}

	public LoggingLevel GetLogLevel()
	{
		string logLevelValue = _configuration.AppSettings.Settings[LogLevelSettingKey].Value;
		if (Enum.TryParse(logLevelValue, out LoggingLevel logLevel))
			return logLevel;
		return LoggingLevel.Error; // Default
	}

	public void SetLanguage(Language language)
	{
		_configuration.AppSettings.Settings[LanguageSettingKey].Value = $"{language}";
		_configuration.Save(ConfigurationSaveMode.Modified);
		ConfigurationManager.RefreshSection(AppSettingsSection);
		eventService.Publish(new LanguageChangedEvent(language));
	}

	public void SetLogLevel(LoggingLevel logLevel)
	{
		_configuration.AppSettings.Settings[LogLevelSettingKey].Value = $"{logLevel}";
		_configuration.Save(ConfigurationSaveMode.Modified);
		ConfigurationManager.RefreshSection(AppSettingsSection);
		eventService.Publish(new LogLevelChangedEvent(logLevel));
	}
}
