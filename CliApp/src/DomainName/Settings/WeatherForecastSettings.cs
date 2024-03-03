using System.ComponentModel;

using DomainName.Enumerators;

using Spectre.Console.Cli;

namespace DomainName.Settings;

public class WeatherForecastSettings : CommandSettings
{
	[Description("The number of weather forecasts to display.")]
	[CommandArgument(0, "[count]")]
	public int Count { get; set; }

	[Description("The unit of temperature.")]
	[CommandOption("-u|--unit")]
	public TemperatureUnit? Unit { get; set; }
}