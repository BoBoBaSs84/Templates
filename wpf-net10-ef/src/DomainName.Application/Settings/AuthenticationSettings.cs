using BB84.Notifications;
using BB84.SourceGenerators.Attributes;

namespace DomainName.Application.Settings;

/// <summary>
/// Represents the authentication settings for the application.
/// </summary>
public sealed partial class AuthenticationSettings : NotifiableObject
{
	private string _username = string.Empty;
	private string _password = string.Empty;

	/// <summary>
	/// Gets or sets the user name for authentication.
	/// </summary>
	[GenerateIniFileValue]
	public string Username
	{
		get => _username;
		set => SetProperty(ref _username, value);
	}

	/// <summary>
	/// Gets or sets the password for authentication.
	/// </summary>
	[GenerateIniFileValue]
	public string Password
	{
		get => _password;
		set => SetProperty(ref _password, value);
	}
}
