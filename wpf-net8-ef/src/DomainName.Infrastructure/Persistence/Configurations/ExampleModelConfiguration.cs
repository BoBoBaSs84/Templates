using System.Diagnostics.CodeAnalysis;

using BB84.EntityFrameworkCore.Repositories.SqlServer.Configurations;

using DomainName.Domain.Entities;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DomainName.Infrastructure.Persistence.Configurations;

/// <summary>
/// The example model configuration class.
/// </summary>
/// <inheritdoc/>
[SuppressMessage("Style", "IDE0058", Justification = "Not relevant here, entity type configuration.")]
internal sealed class ExampleModelConfiguration : AuditedConfiguration<ExampleEntity>
{
	public override void Configure(EntityTypeBuilder<ExampleEntity> builder)
	{
		base.Configure(builder);

		builder.Property(e => e.FirstName)
			.HasMaxLength(50)
			.IsRequired();

		builder.Property(e => e.LastName)
			.HasMaxLength(50)
			.IsRequired();

		builder.Property(e => e.Age)
			.HasDefaultValue(18);
	}
}
