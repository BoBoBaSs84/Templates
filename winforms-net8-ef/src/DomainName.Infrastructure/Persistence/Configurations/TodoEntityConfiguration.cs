using DomainName.Domain.Entities;
using DomainName.Infrastructure.Persistence.Configurations.Base;
using DomainName.Infrastructure.Persistence.Converters;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DomainName.Infrastructure.Persistence.Configurations;

/// <summary>
/// Represents the configuration for the <see cref="TodoEntity"/> entity.
/// </summary>
internal sealed class TodoListConfiguration : EntityBaseConfiguration<TodoEntity>
{
	/// <inheritdoc/>
	public override void Configure(EntityTypeBuilder<TodoEntity> builder)
	{
		base.Configure(builder);

		builder.ToTable("Todos");

		builder.Property(p => p.Color)
			.HasConversion(new ColorConverter());
	}
}
