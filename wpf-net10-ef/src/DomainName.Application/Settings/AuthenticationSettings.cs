using BB84.SourceGenerators.Attributes;

namespace DomainName.Application.Settings;

/// <summary>
/// Represents the authentication settings for the application.
/// </summary>
[GenerateNotifications]
public sealed partial class AuthenticationSettings
{
	/// <summary>
	/// Gets or sets the user name for authentication.
	/// </summary>
	[GenerateIniFileValue]
	public partial string Username { get; set; }

	/// <summary>
	/// Gets or sets the password for authentication.
	/// </summary>
	[GenerateIniFileValue]
	public partial string Password { get; set; }
}
