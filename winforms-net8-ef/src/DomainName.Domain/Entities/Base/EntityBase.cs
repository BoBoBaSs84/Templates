using BB84.EntityFrameworkCore.Entities.Abstractions;
using BB84.Notifications;

namespace DomainName.Domain.Entities.Base;

/// <summary>
/// The base class for all entities in the domain.
/// </summary>
public abstract class EntityBase : ValidatableObject, IIdentityEntity
{
	/// <inheritdoc/>
	public Guid Id { get; set; } = default!;
	
	/// <inheritdoc/>
	public byte[] Timestamp { get; } = default!;
}
