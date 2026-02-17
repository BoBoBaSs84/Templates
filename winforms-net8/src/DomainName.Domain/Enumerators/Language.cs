using System.ComponentModel.DataAnnotations;

using DomainName.Domain.Properties;

namespace DomainName.Domain.Enumerators;

/// <summary>
/// Represents the application languages.
/// </summary>
public enum Language
{
	[Display(ShortName = nameof(Resources.Language_English_ShortName), Name = nameof(Resources.Language_English_Name), ResourceType = typeof(Resources))]
	English,
	[Display(ShortName = nameof(Resources.Language_French_ShortName), Name = nameof(Resources.Language_French_Name), ResourceType = typeof(Resources))]
	French,
	[Display(ShortName = nameof(Resources.Language_German_ShortName), Name = nameof(Resources.Language_German_Name), ResourceType = typeof(Resources))]
	German,
	[Display(ShortName = nameof(Resources.Language_Italian_ShortName), Name = nameof(Resources.Language_Italian_Name), ResourceType = typeof(Resources))]
	Italian,
	[Display(ShortName = nameof(Resources.Language_Spanish_ShortName), Name = nameof(Resources.Language_Spanish_Name), ResourceType = typeof(Resources))]
	Spanish
}
