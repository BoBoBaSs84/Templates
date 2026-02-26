using DomainName.Domain.Abstractions.Entities.Base;
using DomainName.Domain.Entities.Base;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DomainName.Infrastructure.Persistence.Configurations.Base;

/// <summary>
/// Represents the base configuration for an entity.
/// </summary>
/// <typeparam name="TEntity">The type of the entity to configure.</typeparam>
internal abstract class EntityBaseConfiguration<TEntity> : IEntityTypeConfiguration<TEntity>
	where TEntity : EntityBase, IEntityBase
{
	/// <inheritdoc/>
	public virtual void Configure(EntityTypeBuilder<TEntity> builder)
	{
		builder.HasKey(e => e.Id);

		builder.Property(e => e.Id)
			.HasColumnOrder(1)
			.ValueGeneratedOnAdd();
	}
}
