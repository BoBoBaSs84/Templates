using DomainName.Domain.Events.Base;

namespace DomainName.Application.Events;

/// <summary>
/// Represents an event that is published when a file is opened.
/// </summary>
/// <param name="fileContent">The content of the opened file as a byte array.</param>
public sealed class FileOpenedEvent(byte[] fileContent) : EventBase
{
	/// <summary>
	/// Gets the content of the opened file as a byte array.
	/// </summary>
	public byte[] FileContent { get; } = fileContent;
}
