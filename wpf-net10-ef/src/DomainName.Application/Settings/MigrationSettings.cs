using BB84.SourceGenerators.Attributes;

namespace DomainName.Application.Settings;

/// <summary>
/// Represents the database migration settings for the application.
/// </summary>
[GenerateNotifications]
public sealed partial class MigrationSettings
{
	/// <summary>
	/// Initializes a new instance of the <see cref="MigrationSettings"/> class.
	/// </summary>
	public MigrationSettings()
	{
		TableName = "Migrations";
	}

	/// <summary>
	/// Gets or sets the table schema for the migration table.
	/// </summary>
	[GenerateIniFileValue]
	public partial string? TableSchema { get; set; }

	/// <summary>
	/// Gets or sets the table name for the migration table.
	/// </summary>
	[GenerateIniFileValue]
	public partial string TableName { get; set; }
}
