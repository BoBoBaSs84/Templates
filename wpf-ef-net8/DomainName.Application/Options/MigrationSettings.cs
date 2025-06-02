using System.ComponentModel.DataAnnotations;

namespace DomainName.Application.Options;

/// <summary>
/// The migration settings class.
/// </summary>
public sealed class MigrationSettings
{
	/// <summary>
	/// The table schema for the migration table.
	/// </summary>
	[Required]
	public required string TableSchema { get; init; }

	/// <summary>
	/// The table name for the migration table.
	/// </summary>
	[Required]
	public required string TableName { get; init; }
}
