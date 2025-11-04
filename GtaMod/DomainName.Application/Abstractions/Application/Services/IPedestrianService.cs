using GTA;

namespace DomainName.Application.Abstractions.Application.Services;

/// <summary>
/// Represents a collection service contract of pedestrian (<see cref="Ped"/>) entities.
/// </summary>
public interface IPedestrianService : ICollection<Ped>
{ }
