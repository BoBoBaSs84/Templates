using BB84.SourceGenerators.Attributes;

namespace DomainName.Application.Enumerators;

/// <summary>
/// Represents the supported languages for the application.
/// </summary>
[GenerateEnumeratorExtensions]
public enum Language
{
	/// <summary>
	/// Represents the English language.
	/// </summary>
	[System.ComponentModel.Description("en-US")]
	English,
	/// <summary>
	/// Represents the Spanish language.
	/// </summary>
	[System.ComponentModel.Description("es-ES")]
	Spanish,
	/// <summary>
	/// Represents the French language.
	/// </summary>
	[System.ComponentModel.Description("fr-FR")]
	French,
	/// <summary>
	/// Represents the German language.
	/// </summary>
	[System.ComponentModel.Description("de-DE")]
	German,
	/// <summary>
	/// Represents the Italian language.
	/// </summary>
	[System.ComponentModel.Description("it-IT")]
	Italian
}
