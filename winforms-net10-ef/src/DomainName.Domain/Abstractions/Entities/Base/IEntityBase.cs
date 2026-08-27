using BB84.EntityFrameworkCore.Entities.Abstractions.Components;

namespace DomainName.Domain.Abstractions.Entities.Base;

/// <summary>
/// Represents the base abstraction for entities.
/// </summary>
public interface IEntityBase : IIdentity<Guid>
{ }
