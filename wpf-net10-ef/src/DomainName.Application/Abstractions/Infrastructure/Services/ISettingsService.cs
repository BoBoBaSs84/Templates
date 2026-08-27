using DomainName.Application.Settings;

namespace DomainName.Application.Abstractions.Infrastructure.Services;

/// <summary>
/// Represents a service for managing application settings, providing methods to retrieve and save
/// settings asynchronously.
/// </summary>
public interface ISettingsService
{
	/// <summary>
	/// Gets the application settings asynchronously, allowing for cancellation through a CancellationToken.
	/// </summary>
	/// <remarks>
	/// This method retrieves the current settings of the application, which may include user preferences,
	/// configuration options, and other relevant data necessary for the application's operation.
	/// </remarks>
	/// <param name="cancellationToken">A token to monitor for cancellation requests.</param>
	/// <returns>A task that represents the asynchronous operation.</returns>
	Task LoadAsync(CancellationToken cancellationToken = default);

	/// <summary>
	/// Saves the application settings asynchronously, allowing for cancellation through a CancellationToken.
	/// </summary>
	/// <remarks>
	/// This method persists the provided settings, which may include user preferences, configuration options,
	/// and other relevant data necessary for the application's operation.
	/// </remarks>
	/// <param name="settings">The application settings to save.</param>
	/// <param name="cancellationToken">A token to monitor for cancellation requests.</param>
	/// <returns>A task that represents the asynchronous operation.</returns>
	Task SaveAsync(ApplicationSettings settings, CancellationToken cancellationToken = default);
}
