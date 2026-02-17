namespace DomainName.Application.Abstractions.Application.Services;

/// <summary>
/// Represents a service interface that manages the application's language settings and raises events
/// </summary>
public interface ILanguageService
{
	/// <summary>
	/// Gets the current language setting from the application's configuration.
	/// </summary>
	/// <returns>The current language setting.</returns>
	string GetLanguage();

	/// <summary>
	/// Sets the language setting in the application's configuration and raises an event
	/// to notify subscribers of the change.
	/// </summary>
	/// <param name="language">The new language to set.</param>
	void SetLanguage(string language);
}
