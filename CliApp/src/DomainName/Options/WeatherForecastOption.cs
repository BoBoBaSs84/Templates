using DomainName.Enumerators;

using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;

namespace DomainName.Options;

/// <summary>
/// Represents the configuration options for weather forecasts.
/// </summary>
public sealed class WeatherForecastOption : IEquatable<WeatherForecastOption>
{
	/// <summary>
	/// Gets the name of the configuration section for weather forecast options.
	/// </summary>
	public const string SectionName = "WeatherForecast";

	/// <summary>
	/// Gets or sets the number of forecasts to retrieve.
	/// </summary>
	public int NumberOfForecasts { get; set; } = 5;

	/// <summary>
	/// Gets or sets the temperature unit to use.
	/// </summary>
	public TemperatureUnit Unit { get; set; } = TemperatureUnit.Celsius;

	/// <summary>
	/// Gets or sets a value indicating whether to include humidity in the forecast.
	/// </summary>
	public bool IncludeHumidity { get; set; } = true;

	/// <summary>
	/// Gets or sets a value indicating whether to include wind speed in the forecast.
	/// </summary>
	public bool IncludeWindSpeed { get; set; } = true;

	/// <summary>
	/// Binds the weather forecast options to the service collection.
	/// </summary>
	/// <param name="services">The service collection to bind the options to.</param>
	/// <returns>The options builder for further configuration.</returns>
	public static OptionsBuilder<WeatherForecastOption> Bind(IServiceCollection services)
	{
		return services.AddOptions<WeatherForecastOption>()
			.BindConfiguration(SectionName)
			.ValidateOnStart();
	}

	/// <inheritdoc/>
	public bool Equals(WeatherForecastOption? other)
		=> other is not null && this is not null && NumberOfForecasts == other.NumberOfForecasts
			&& IncludeHumidity == other.IncludeHumidity && IncludeWindSpeed == other.IncludeWindSpeed;

	/// <inheritdoc/>
	public override bool Equals(object? obj)
		=> Equals(obj as WeatherForecastOption);

	/// <inheritdoc/>
	public override int GetHashCode()
		=> HashCode.Combine(NumberOfForecasts, Unit, IncludeHumidity, IncludeWindSpeed);
}
