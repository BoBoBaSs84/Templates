using DomainName.Domain.Entities;
using DomainName.Infrastructure.Persistence.Configurations.Base;
using DomainName.Infrastructure.Persistence.Converters;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DomainName.Infrastructure.Persistence.Configurations;

/// <summary>
/// Represents the configuration for the <see cref="TodoItem"/> entity.
/// </summary>
internal sealed class TodoItemConfiguration : EntityBaseConfiguration<TodoItem>
{
	/// <inheritdoc/>
	public override void Configure(EntityTypeBuilder<TodoItem> builder)
	{
		base.Configure(builder);

		builder.ToTable("TodoItems");

		builder.Property(p => p.Color)
			.HasConversion(new ColorConverter())
			.IsRequired(false);
	}
}
