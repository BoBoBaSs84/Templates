using DomainName.Domain.Events.Base;

namespace DomainName.Application.Events;

/// <summary>
/// Represents an event that is raised when a restart of the application is requested,
/// typically after a language change or other significant setting change that requires
/// a restart to take effect.
/// </summary>
public sealed class RestartApplicationEvent : EventBase
{ }
