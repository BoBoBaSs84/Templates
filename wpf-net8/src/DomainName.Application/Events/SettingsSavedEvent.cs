using DomainName.Domain.Events.Base;

namespace DomainName.Application.Events;

/// <summary>
/// Represents an event that is raised when the application settings have been successfully saved, allowing
/// other components of the application to respond to changes in settings and update their behavior accordingly.
/// </summary>
public sealed class SettingsSavedEvent : EventBase
{ }
