using BB84.Notifications;
using BB84.SourceGenerators.Attributes;

using DomainName.Application.Enumerators;

namespace DomainName.Application.Settings;

/// <summary>
/// Represents the general settings for the application.
/// </summary>
public sealed class GeneralSettings : NotifiableObject
{
	private Language _language = Language.English;

	/// <summary>
	/// Gets or sets the language preference for the application.
	/// </summary>
	[GenerateIniFileValue]
	public Language Language
	{
		get => _language;
		set => SetProperty(ref _language, value);
	}
}
