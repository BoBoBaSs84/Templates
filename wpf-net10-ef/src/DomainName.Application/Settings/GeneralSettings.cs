using BB84.SourceGenerators.Attributes;

using DomainName.Application.Enumerators;

using Microsoft.Extensions.Logging;

namespace DomainName.Application.Settings;

/// <summary>
/// Represents the general settings for the application.
/// </summary>
[GenerateNotifications]
public sealed partial class GeneralSettings
{
	/// <summary>
	/// Initializes a new instance of the <see cref="GeneralSettings"/> class
	/// with default values.
	/// </summary>
	public GeneralSettings()
	{
		_language = Language.English;
		_logLevel = LogLevel.Warning;
	}

	/// <summary>
	/// Gets or sets the language preference for the application.
	/// </summary>
	[GenerateIniFileValue]
	public partial Language Language { get; set; }

	/// <summary>
	/// Gets or sets the log level for the application, determining the
	/// verbosity of log output.
	/// </summary>
	[GenerateIniFileValue]
	public partial LogLevel LogLevel { get; set; }
}
