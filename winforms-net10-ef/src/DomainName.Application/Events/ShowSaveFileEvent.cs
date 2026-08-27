using DomainName.Domain.Events.Base;

namespace DomainName.Application.Events;

/// <summary>
/// Represents an event that is raised when the user wants to show the save file dialog.
/// </summary>
/// <param name="fileContent">The content of the file to be saved.</param>
public sealed class ShowSaveFileEvent(byte[] fileContent) : EventBase
{
	/// <summary>
	/// Gets the content of the file to be saved.
	/// </summary>
	public byte[] FileContent { get; } = fileContent;
}
