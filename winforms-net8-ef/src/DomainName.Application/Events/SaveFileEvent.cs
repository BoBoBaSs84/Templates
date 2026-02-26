using DomainName.Domain.Events.Base;

namespace DomainName.Application.Events;

/// <summary>
/// Represents an event that is triggered when a file needs to be saved.
/// It contains the file name and the file content as a byte array.
/// </summary>
/// <param name="fileName">The name of the file to be saved.</param>
/// <param name="fileContent">The content of the file to be saved as a byte array.</param>
public sealed class SaveFileEvent(string fileName, byte[] fileContent) : EventBase
{
	/// <summary>
	/// Gets the name of the file to be saved.
	/// </summary>
	public string FileName { get; } = fileName;

	/// <summary>
	/// Gets the content of the file to be saved as a byte array.
	/// </summary>
	public byte[] FileContent { get; } = fileContent;
}
