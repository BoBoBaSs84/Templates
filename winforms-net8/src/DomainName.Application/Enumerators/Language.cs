using System.ComponentModel.DataAnnotations;

using DomainName.Application.Properties;

namespace DomainName.Application.Enumerators;

/// <summary>
/// Represents the application languages.
/// </summary>
public enum Language
{
	/// <summary>
	/// The default language of the application, which is English.
	/// </summary>
	[Display(ShortName = nameof(Resources.Language_English_ShortName), Name = nameof(Resources.Language_English_Name), ResourceType = typeof(Resources))]
	English,
	/// <summary>
	/// The French language, which is the second most widely spoken language in the world and is used in many countries around the world, including France, Canada, and parts of Africa.
	/// </summary>
	[Display(ShortName = nameof(Resources.Language_French_ShortName), Name = nameof(Resources.Language_French_Name), ResourceType = typeof(Resources))]
	French,
	/// <summary>
	/// The German language, which is the most widely spoken language in the European Union and is used in Germany, Austria, Switzerland, and parts of Belgium and Luxembourg.
	/// </summary>
	[Display(ShortName = nameof(Resources.Language_German_ShortName), Name = nameof(Resources.Language_German_Name), ResourceType = typeof(Resources))]
	German,
	/// <summary>
	/// The Italian language, which is primarily spoken in Italy and parts of Switzerland.
	/// </summary>
	[Display(ShortName = nameof(Resources.Language_Italian_ShortName), Name = nameof(Resources.Language_Italian_Name), ResourceType = typeof(Resources))]
	Italian,
	/// <summary>
	/// The Spanish language, which is primarily spoken in Spain and many countries in Latin America.
	/// </summary>
	[Display(ShortName = nameof(Resources.Language_Spanish_ShortName), Name = nameof(Resources.Language_Spanish_Name), ResourceType = typeof(Resources))]
	Spanish
}
