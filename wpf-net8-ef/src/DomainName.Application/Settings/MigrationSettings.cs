using BB84.Notifications;
using BB84.SourceGenerators.Attributes;

namespace DomainName.Application.Settings;

/// <summary>
/// Represents the database migration settings for the application.
/// </summary>
public sealed partial class MigrationSettings : NotifiableObject
{
	private string? _tableSchema;
	private string _tableName = string.Empty;

	/// <summary>
	/// Gets or sets the table schema for the migration table.
	/// </summary>
	[GenerateIniFileValue]
	public string? TableSchema
	{
		get => _tableSchema;
		set => SetProperty(ref _tableSchema, value);
	}

	/// <summary>
	/// Gets or sets the table name for the migration table.
	/// </summary>
	[GenerateIniFileValue]
	public string TableName
	{
		get => _tableName;
		set => SetProperty(ref _tableName, value);
	}
}
