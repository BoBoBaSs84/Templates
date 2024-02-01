using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

using DomainName.Domain.Interfaces.Models.Base;

using Microsoft.EntityFrameworkCore;

namespace DomainName.Domain.Models.Base;

/// <summary>
/// The data model base class.
/// </summary>
public abstract class DataModelBase : ModelBase, IDataModelBase
{
	/// <inheritdoc/>
	[Key, Column(Order = 1)]
	[Comment("The primary key of the table.")]
	[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
	public Guid Id { get; private set; } = default!;

	/// <inheritdoc/>
	[Timestamp, Column(Order = 2)]
	[Comment("The current timestamp or row version.")]
	[DatabaseGenerated(DatabaseGeneratedOption.Computed)]
	public byte[] Timestamp { get; private set; } = default!;

	/// <inheritdoc/>
	[MaxLength(256), Column(Order = 3)]
	[Comment("The creator of the data row.")]
	public string CreatedBy { get; set; } = string.Empty;

	/// <inheritdoc/>
	[MaxLength(256), Column(Order = 4)]
	[Comment("The last modifier of the data row.")]
	public string? ModifiedBy { get; set; }
}
