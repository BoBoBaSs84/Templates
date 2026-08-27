using DomainName.Domain.Events.Base;

namespace DomainName.Application.Events;

/// <summary>
/// Represents an event that is published when a file is saved.
/// </summary>
/// <param name="filePath">The path of the saved file.</param>
public sealed class FileSavedEvent(string filePath) : EventBase
{
	/// <summary>
	/// Gets the path of the saved file.
	/// </summary>
	public string FilePath { get; init; } = filePath;
}
