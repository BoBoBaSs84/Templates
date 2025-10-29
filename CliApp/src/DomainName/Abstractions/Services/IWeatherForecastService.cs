using DomainName.Models;

namespace DomainName.Abstractions.Services;

/// <summary>
/// Represents a service interface for retrieving weather forecasts.
/// </summary>
public interface IWeatherForecastService
{
	/// <summary>
	/// Retrieves a collection of weather forecasts.
	/// </summary>
	/// <param name="count">The number of forecasts to retrieve.</param>
	/// <returns>A collection of <see cref="WeatherForecast"/> objects.</returns>
	IEnumerable<WeatherForecast> GetForecasts(int count);
}
