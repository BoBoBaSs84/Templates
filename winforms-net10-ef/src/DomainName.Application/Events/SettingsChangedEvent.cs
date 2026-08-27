using DomainName.Domain.Events.Base;

namespace DomainName.Application.Events;

/// <summary>
/// Represents an event that is triggered when application settings have been changed,
/// allowing other parts of the application to respond to changes.
/// </summary>
public sealed class SettingsChangedEvent : EventBase
{ }
