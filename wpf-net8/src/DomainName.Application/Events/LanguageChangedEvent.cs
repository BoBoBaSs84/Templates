using DomainName.Domain.Events.Base;

namespace DomainName.Application.Events;

/// <summary>
/// Represents an event that is raised when the application's language has been changed.
/// </summary>
/// <param name="language">The new language that has been set.</param>
public sealed class LanguageChangedEvent(string language) : EventBase
{
	/// <summary>
	/// Gets the new language that has been set.
	/// </summary>
	public string Language { get; } = language;
}
