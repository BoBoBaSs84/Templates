using BB84.SourceGenerators.Attributes;

using DomainName.Application.Enumerators;

namespace DomainName.Application.Settings;

/// <summary>
/// Represents the general settings for the application.
/// </summary>
[GenerateNotifications]
public sealed partial class GeneralSettings
{
	/// <summary>
	/// Gets or sets the language preference for the application.
	/// </summary>
	[GenerateIniFileValue]
	public partial Language Language { get; set; }
}
