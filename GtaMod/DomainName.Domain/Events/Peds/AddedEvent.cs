using DomainName.Domain.Events.Base;

namespace DomainName.Domain.Events.Peds;

/// <summary>
/// Represents the event data for when a ped is added.
/// </summary>
/// <param name="source">The source of the event.</param>
/// <param name="pedId">The unique identifier of the ped that was added.</param>
public sealed class AddedEvent(string source, int pedId) : PedEventBase(source, pedId)
{ }
