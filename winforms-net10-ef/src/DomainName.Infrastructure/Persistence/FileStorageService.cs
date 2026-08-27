using DomainName.Application.Abstractions.Application.Services;
using DomainName.Application.Abstractions.Infrastructure.Persistence;
using DomainName.Application.Abstractions.Infrastructure.Services;
using DomainName.Application.Events;

using Microsoft.Extensions.Logging;

namespace DomainName.Infrastructure.Persistence;

/// <summary>
/// Represents a service for file storage operations, such as saving and retrieving
/// files from a storage medium.
/// </summary>
/// <param name="eventService"> The event service to publish events related to file operations.</param>
/// <param name="loggerService"> The logger service to log exceptions and other information related to file operations.</param>
/// <param name="providerService"> The provider service to access the file system for reading and writing files.</param>
internal sealed class FileStorageService(IEventService eventService, ILoggerService<FileStorageService> loggerService, IProviderService providerService) : IFileStorageService
{
	private static readonly Action<ILogger, Exception?> LogException =
		LoggerMessage.Define(LogLevel.Error, 0, "Exception occured.");

	public async Task GetFileAsync(string filePath, CancellationToken cancellationToken = default)
	{
		try
		{
			byte[] fileContent = await providerService.File
				.ReadAllBytesAsync(filePath, cancellationToken)
				.ConfigureAwait(false);

			eventService.Publish(new FileOpenedEvent(fileContent));
		}
		catch (Exception ex)
		{
			loggerService.Log(LogException, ex);
			eventService.Publish(new ShowErrorEvent(ex.Message));
		}
	}

	public async Task SaveFileAsync(string filePath, byte[] content, CancellationToken cancellationToken = default)
	{
		try
		{
			if (content.Length == 0)
				throw new ArgumentException("File content cannot be empty.", nameof(content));

			await providerService.File
				.WriteAllBytesAsync(filePath, content, cancellationToken)
				.ConfigureAwait(false);

			eventService.Publish(new FileSavedEvent(filePath));
		}
		catch (Exception ex)
		{
			loggerService.Log(LogException, ex);
			eventService.Publish(new ShowErrorEvent(ex.Message));
		}
	}
}
