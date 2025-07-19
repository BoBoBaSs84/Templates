using DomainName.Domain.Entities;
using DomainName.Infrastructure.Persistence.Configurations.Base;
using DomainName.Infrastructure.Persistence.Converters;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DomainName.Infrastructure.Persistence.Configurations;

/// <summary>
/// Represents the configuration for the <see cref="TodoList"/> entity.
/// </summary>
internal sealed class TodoListConfiguration : EntityBaseConfiguration<TodoList>
{
	/// <inheritdoc/>
	public override void Configure(EntityTypeBuilder<TodoList> builder)
	{
		base.Configure(builder);

		builder.ToTable("TodoLists");

		builder.Property(p => p.Color)
			.HasConversion(new ColorConverter())
			.IsRequired(false);

		builder.HasMany(hm => hm.Items)
			.WithOne(wo => wo.List)
			.HasForeignKey(i => i.ListId)
			.OnDelete(DeleteBehavior.Cascade)
			.IsRequired();
	}
}
