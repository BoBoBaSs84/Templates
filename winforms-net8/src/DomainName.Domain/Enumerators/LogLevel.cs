using System.ComponentModel.DataAnnotations;

using DomainName.Domain.Properties;

namespace DomainName.Domain.Enumerators;

/// <summary>
/// Represents the application log level.
/// </summary>
public enum LogLevel
{
	[Display(ResourceType = typeof(Resources),
		Name = nameof(Resources.LogLevel_None_Name),
		ShortName = nameof(Resources.LogLevel_None_ShortName))]
	None = 0,
	[Display(ResourceType = typeof(Resources),
		Name = nameof(Resources.LogLevel_Debug_Name),
		ShortName = nameof(Resources.LogLevel_Debug_ShortName))]
	Debug = 1 << 0,
	[Display(ResourceType = typeof(Resources), Name = "", ShortName = "")]
	Information = 1 << 1,
	[Display(ResourceType = typeof(Resources), Name = "", ShortName = "")]
	Warning = 1 << 2,
	[Display(ResourceType = typeof(Resources), Name = "", ShortName = "")]
	Error = 1 << 3,
	[Display(ResourceType = typeof(Resources), Name = "", ShortName = "")]
	Critical = 1 << 4
}
