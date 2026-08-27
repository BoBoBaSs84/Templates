using System.Configuration;

using DomainName.Application.Abstractions.Application.Services;
using DomainName.Application.Enumerators;

using Microsoft.Extensions.Logging;

namespace DomainName.Application.Services;

/// <summary>
/// Represents a service responsible for managing application settings, such as user preferences,
/// configuration options, and other customizable parameters.
/// </summary>
internal sealed class SettingsService : ISettingsService
{
	private const string AppSettingsSection = "appSettings";
	private const string ConnectionSettingKey = "dbConnection";
	private const string LanguageSettingKey = "language";
	private const string LogLevelSettingKey = "logLevel";
	private readonly Configuration _configuration = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);

	public string GetDatabaseConnection()
		=> _configuration.AppSettings.Settings[ConnectionSettingKey].Value;

	public Language GetLanguage()
	{
		string languageValue = _configuration.AppSettings.Settings[LanguageSettingKey].Value;
		if (Enum.TryParse(languageValue, out Language language))
			return language;
		return Language.English; // Default
	}

	public LogLevel GetLogLevel()
	{
		string logLevelValue = _configuration.AppSettings.Settings[LogLevelSettingKey].Value;
		if (Enum.TryParse(logLevelValue, out LogLevel logLevel))
			return logLevel;
		return LogLevel.Error; // Default
	}

	public void SetDatabaseConnection(string databaseConnection)
	{
		_configuration.AppSettings.Settings[ConnectionSettingKey].Value = $"{databaseConnection}";
		_configuration.Save(ConfigurationSaveMode.Modified);
		ConfigurationManager.RefreshSection(AppSettingsSection);
	}

	public void SetLanguage(Language language)
	{
		_configuration.AppSettings.Settings[LanguageSettingKey].Value = $"{language}";
		_configuration.Save(ConfigurationSaveMode.Modified);
		ConfigurationManager.RefreshSection(AppSettingsSection);
	}

	public void SetLogLevel(LogLevel logLevel)
	{
		_configuration.AppSettings.Settings[LogLevelSettingKey].Value = $"{logLevel}";
		_configuration.Save(ConfigurationSaveMode.Modified);
		ConfigurationManager.RefreshSection(AppSettingsSection);
	}
}
