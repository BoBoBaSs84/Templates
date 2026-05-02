using BB84.Notifications;
using BB84.SourceGenerators.Attributes;

namespace DomainName.Application.Settings;

/// <summary>
/// Represents the database and connection settings for the application.
/// </summary>
public sealed partial class DatabaseSettings : NotifiableObject
{
	private string _server = string.Empty;
	private string _database = string.Empty;
	private bool _useEncryption = true;
	private bool _trustServerCertificate = true;
	private bool _useIntegratedSecurity;

	/// <summary>
	/// Gets or sets the server name or address for the database connection.
	/// </summary>
	[GenerateIniFileValue]
	public string Server
	{
		get => _server;
		set => SetProperty(ref _server, value);
	}

	/// <summary>
	/// Gets or sets the database name for the database connection.
	/// </summary>
	[GenerateIniFileValue]
	public string Database
	{
		get => _database;
		set => SetProperty(ref _database, value);
	}

	/// <summary>
	/// Gets or sets a value indicating whether to use integrated security for the database connection.
	/// </summary>
	[GenerateIniFileValue]
	public bool UseIntegratedSecurity
	{
		get => _useIntegratedSecurity;
		set => SetProperty(ref _useIntegratedSecurity, value);
	}

	/// <summary>
	/// Gets or sets a value indicating whether to use encryption for the database connection.
	/// </summary>
	[GenerateIniFileValue]
	public bool UseEncryption
	{
		get => _useEncryption;
		set => SetProperty(ref _useEncryption, value);
	}

	/// <summary>
	/// Gets or sets a value indicating whether to trust the server certificate for the database connection.
	/// </summary>
	[GenerateIniFileValue]
	public bool TrustServerCertificate
	{
		get => _trustServerCertificate;
		set => SetProperty(ref _trustServerCertificate, value);
	}

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
