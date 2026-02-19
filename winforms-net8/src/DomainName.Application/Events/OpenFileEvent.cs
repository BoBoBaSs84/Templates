using DomainName.Domain.Events.Base;

namespace DomainName.Application.Events;

/// <summary>
/// Represents an event that is triggered when a file needs to be opened.
/// This event contains the file path of the file to be opened.
/// </summary>
/// <param name="filePath"></param>
public class OpenFileEvent(string filePath) : EventBase
{
	/// <summary>
	/// Gets the file path of the file to be opened.
	/// </summary>
	public string FilePath { get; } = filePath;
}
