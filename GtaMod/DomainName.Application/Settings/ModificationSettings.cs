using BB84.SourceGenerators.Attributes;

namespace DomainName.Application.Settings;

/// <summary>
/// Represents the settings for the modification.
/// </summary>
[GenerateIniFile]
public sealed partial class ModificationSettings
{
	/// <summary>
	/// Gets the general settings for the modification.
	/// </summary>
	[GenerateIniFileSection]
	public GeneralSettings General { get; } = new();
}
