using DomainName.Domain.Events.Base;

namespace DomainName.Domain.Events.Peds;

/// <summary>
/// Represents the event data for when a ped dies.
/// </summary>
/// <param name="source">The source of the event.</param>
/// <param name="pedId">The unique identifier of the ped that died.</param>
public sealed class DiedEvent(string source, int pedId) : PedEventBase(source, pedId)
{ }
