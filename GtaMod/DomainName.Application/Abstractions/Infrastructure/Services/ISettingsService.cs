namespace DomainName.Application.Abstractions.Infrastructure.Services;

/// <summary>
/// Represents a service responsible for managing application settings. This service provides methods to load
/// and save settings, allowing the application to persist user preferences and configuration across sessions.
/// </summary>
public interface ISettingsService
{
	/// <summary>
	/// Loads the settings from the storage. This method should be called before accessing any settings properties to ensure that the settings are up-to-date.
	/// </summary>
	void Load();

	/// <summary>
	/// Saves the current settings to the storage. This method should be called after modifying any settings properties to persist the changes.
	/// </summary>
	void Save();
}
