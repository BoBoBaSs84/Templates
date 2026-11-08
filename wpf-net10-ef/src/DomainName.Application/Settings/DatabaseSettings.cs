using BB84.SourceGenerators.Attributes;

namespace DomainName.Application.Settings;

/// <summary>
/// Represents the database and connection settings for the application.
/// </summary>
[GenerateNotifications]
public sealed partial class DatabaseSettings
{
	/// <summary>
	/// Gets or sets the server name or address for the database connection.
	/// </summary>
	[GenerateIniFileValue]
	public partial string Server { get; set; }

	/// <summary>
	/// Gets or sets the database name for the database connection.
	/// </summary>
	[GenerateIniFileValue]
	public partial string Database { get; set; }

	/// <summary>
	/// Gets or sets a value indicating whether to use integrated security for the database connection.
	/// </summary>
	[GenerateIniFileValue]
	public partial bool UseIntegratedSecurity { get; set; }

	/// <summary>
	/// Gets or sets a value indicating whether to use encryption for the database connection.
	/// </summary>
	[GenerateIniFileValue]
	public partial bool UseEncryption { get; set; }

	/// <summary>
	/// Gets or sets a value indicating whether to trust the server certificate for the database connection.
	/// </summary>
	[GenerateIniFileValue]
	public partial bool TrustServerCertificate { get; set; }

	/// <summary>
	/// Gets the authentication settings for the database connection.
	/// </summary>
	[GenerateIniFileSection]
	public AuthenticationSettings Authentication { get; } = new();

	/// <summary>
	/// Gets the migration settings for the database.
	/// </summary>
	[GenerateIniFileSection]
	public MigrationSettings Migration { get; } = new();

	/// <summary>
	/// Returns the connection string based on the current database settings.
	/// </summary>
	/// <returns>The connection string to be used for database connections, formatted according to the settings specified in this class.</returns>
	public string GetConnectionString()
	{
		return UseIntegratedSecurity
			? $"Server={Server};Database={Database};Integrated Security=True;Encrypt={UseEncryption};TrustServerCertificate={TrustServerCertificate}"
			: $"Server={Server};Database={Database};User Id={Authentication.Username};Password={Authentication.Password};Encrypt={UseEncryption};TrustServerCertificate={TrustServerCertificate}";
	}
}
