using BB84.SourceGenerators.Attributes;

namespace DomainName.Application.Settings;

/// <summary>
/// Represents the application settings, providing properties and methods to
/// manage and persist various configuration options for the application.
/// </summary>
[GenerateIniFile]
public sealed partial class ApplicationSettings
{
	/// <summary>
	/// Gets the general settings for the application.
	/// </summary>
	[GenerateIniFileSection]
	public GeneralSettings General { get; } = new();
}
