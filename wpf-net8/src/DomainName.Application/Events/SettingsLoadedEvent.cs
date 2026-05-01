using DomainName.Domain.Events.Base;

namespace DomainName.Application.Events;

/// <summary>
/// Represents an event that is triggered when the application settings have been loaded, allowing other
/// components of the application to respond to changes in settings and update their behavior accordingly.
/// </summary>
public sealed class SettingsLoadedEvent : EventBase
{ }
