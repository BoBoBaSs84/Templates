using BB84.EntityFrameworkCore.Entities.Abstractions;

using DomainName.Domain.Entities.Base;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DomainName.Infrastructure.Persistence.Configurations.Base;

/// <summary>
/// Represents the base configuration for an entity.
/// </summary>
/// <typeparam name="TEntity">The type of the entity to configure.</typeparam>
internal abstract class EntityBaseConfiguration<TEntity> : IEntityTypeConfiguration<TEntity>
	where TEntity : EntityBase, IIdentityEntity
{
	/// <inheritdoc/>
	public virtual void Configure(EntityTypeBuilder<TEntity> builder)
	{
		builder.HasKey(e => e.Id);

		builder.Property(e => e.Id)
			.HasColumnOrder(1)
			.ValueGeneratedOnAdd();

		builder.Property(e => e.Timestamp)
			.HasColumnOrder(2)
			.IsRowVersion()
			.HasDefaultValueSql("CURRENT_TIMESTAMP");

		builder.Ignore(i => i.IsValid)
			.Ignore(i => i.HasErrors);
	}
}
