using DomainName.Domain.Enumerators;

namespace DomainName.Application.Abstractions.Application.Services;

/// <summary>
/// Represents a service interface responsible for managing application settings, such as user preferences,
/// configuration options, and other customizable parameters.
/// </summary>
public interface ISettingsService
{
	/// <summary>
	/// Retrieves the current language setting from the application's configuration,
	/// which determines the language
	/// </summary>
	/// <returns>The current language setting.</returns>
	Language GetLanguage();

	/// <summary>
	/// Retrieves the current logging level setting from the application's configuration,
	/// which determines the verbosity of logging output.
	/// </summary>
	/// <returns>The current logging level setting.</returns>
	LoggingLevel GetLogLevel();

	/// <summary>
	/// Sets the language preference in the application's configuration, which determines the language
	/// used for user interfaces and updates the application to reflect the new language setting.
	/// </summary>
	/// <param name="language">The language to set as the current preference for the application.</param>
	void SetLanguage(Language language);

	/// <summary>
	/// Sets the logging level preference in the application's configuration, which determines the verbosity
	/// of logging output. 
	/// </summary>
	/// <param name="logLevel">The logging level to set as the current preference for the application.</param>
	void SetLogLevel(LoggingLevel logLevel);
}
