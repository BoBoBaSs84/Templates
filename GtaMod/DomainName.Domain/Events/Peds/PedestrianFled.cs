using DomainName.Domain.Events.Base;

namespace DomainName.Domain.Events.Peds;

/// <summary>
/// Represents the event data for when a ped flees.
/// </summary>
/// <param name="pedId">The unique identifier of the ped that fled.</param>
public sealed class PedestrianFled(int pedId) : PedEventBase(pedId)
{ }
