using System.ComponentModel;

using DomainName.Enumerators;

using Spectre.Console.Cli;

namespace DomainName.Settings;

/// <summary>
/// Represents the settings for the weather forecast command.
/// </summary>
public sealed class WeatherForecastSettings : CommandSettings
{
	/// <summary>
	/// Gets or sets the number of weather forecasts to display.
	/// </summary>
	[Description("The number of weather forecasts to display.")]
	[CommandArgument(0, "[count]")]
	public int Count { get; set; }

	/// <summary>
	/// Gets or sets the unit of temperature.
	/// </summary>
	[Description("The unit of temperature.")]
	[CommandOption("-u|--unit")]
	public TemperatureUnit? Unit { get; set; }
}
