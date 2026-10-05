using System.Diagnostics.CodeAnalysis;

using DomainName.Abstractions.Services;
using DomainName.Enumerators;
using DomainName.Models;
using DomainName.Options;
using DomainName.Settings;

using Microsoft.Extensions.Options;

using Spectre.Console;
using Spectre.Console.Cli;

namespace DomainName.Commands;

/// <summary>
/// Represents the command to display weather forecasts.
/// </summary>
/// <param name="options">The weather forecast options to use.</param>
/// <param name="weatherForecastService">The weather forecast service to use.</param>
public sealed class WeatherForecastCommand(IOptions<WeatherForecastOption> options, IWeatherForecastService weatherForecastService) : Command<WeatherForecastSettings>
{
	/// <inheritdoc/>
	public override int Execute([NotNull] CommandContext context, [NotNull] WeatherForecastSettings settings, CancellationToken cancellationToken)
	{
		TemperatureUnit unit = settings.Unit ?? options.Value.Unit;

		IEnumerable<WeatherForecast> forecasts = weatherForecastService.GetForecasts(settings.Count);

		Table table = new Table()
			.AddColumn("Date")
			.AddColumn("Temp")
			.AddColumn("Summary");

		foreach (WeatherForecast forecast in forecasts)
		{
			int temperature = unit == TemperatureUnit.Fahrenheit
								? forecast.TemperatureF
								: forecast.TemperatureC;

			_ = table.AddRow(
					forecast.Date.ToShortDateString(),
					temperature.ToString(),
					forecast.Summary);
		}

		_ = table.Expand();

		AnsiConsole.Write(table);

		return 0;
	}
}
