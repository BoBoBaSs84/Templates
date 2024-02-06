using System.Diagnostics.CodeAnalysis;

using DomainName.Domain.Interfaces.Models.Base;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DomainName.Infrastructure.Persistence.Configurations.Base;

/// <summary>
/// The identity model base configuration class.
/// </summary>
/// <typeparam name="T">Must implement the <see cref="IDataModelBase"/> interface.</typeparam>
[SuppressMessage("Style", "IDE0058", Justification = "Not relevant here, entity type configuration.")]
internal abstract class IdentityModelBaseConfiguration<T> : IEntityTypeConfiguration<T> where T : class, IDataModelBase
{
	/// <inheritdoc/>
	public virtual void Configure(EntityTypeBuilder<T> builder)
	{
		builder.HasKey(e => e.Id)
			.IsClustered(false);

		builder.Property(e => e.Id)
			.ValueGeneratedOnAdd();

		builder.Property(e => e.Timestamp)
			.IsConcurrencyToken()
			.IsRowVersion();

		builder.Property(e => e.CreatedBy)
			.IsRequired()
			.IsUnicode();

		builder.Property(e => e.ModifiedBy)
			.IsRequired(false)
			.IsUnicode();
	}
}
