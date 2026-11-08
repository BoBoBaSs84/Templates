using System.ComponentModel;

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
	[Description("en-US")]
	English,
	/// <summary>
	/// Represents the Spanish language.
	/// </summary>
	[Description("es-ES")]
	Spanish,
	/// <summary>
	/// Represents the French language.
	/// </summary>
	[Description("fr-FR")]
	French,
	/// <summary>
	/// Represents the German language.
	/// </summary>
	[Description("de-DE")]
	German,
	/// <summary>
	/// Represents the Italian language.
	/// </summary>
	[Description("it-IT")]
	Italian
}
