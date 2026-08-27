using DomainName.Domain.Abstractions.Entities.Base;

namespace DomainName.Domain.Entities.Base;

/// <summary>
/// Represents the base entity.
/// </summary>
public abstract class EntityBase : IEntityBase
{
	/// <inheritdoc/>
	public Guid Id { get; set; }
}
