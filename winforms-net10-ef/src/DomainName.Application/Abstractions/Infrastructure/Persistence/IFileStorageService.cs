namespace DomainName.Application.Abstractions.Infrastructure.Persistence;

/// <summary>
/// Represents a service interface for file storage operations, such as saving and retrieving
/// files from a storage medium.
/// </summary>
public interface IFileStorageService
{
	/// <summary>
	/// Saves a file to the storage medium.
	/// </summary>
	/// <param name="filePath">The path where the file should be saved.</param>
	/// <param name="content">The content of the file to be saved.</param>
	/// <param name="cancellationToken">A token to monitor for cancellation requests.</param>
	/// <returns>
	/// A task that represents the asynchronous save operation.
	/// </returns>
	Task SaveFileAsync(string filePath, byte[] content, CancellationToken cancellationToken = default);

	/// <summary>
	/// Retrieves a file from the storage medium.
	/// </summary>
	/// <param name="filePath">The path of the file to be retrieved.</param>
	/// <param name="cancellationToken">A token to monitor for cancellation requests.</param>
	/// <returns>
	/// A task that represents the asynchronous save operation.
	/// </returns>
	Task GetFileAsync(string filePath, CancellationToken cancellationToken = default);
}
