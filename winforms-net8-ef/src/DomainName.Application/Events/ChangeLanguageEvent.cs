using DomainName.Domain.Events.Base;

namespace DomainName.Application.Events;

/// <summary>
/// Represents an event that is raised when the application's language is changing.
/// </summary>
/// <param name="language">The new language that should be set.</param>
public sealed class ChangeLanguageEvent(string language) : EventBase
{
	/// <summary>
	/// Gets the new language that should be set.
	/// </summary>
	public string Language { get; } = language;
}
