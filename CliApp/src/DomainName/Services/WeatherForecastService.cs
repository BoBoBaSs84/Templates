using DomainName.Abstractions.Services;
using DomainName.Models;

namespace DomainName.Services;

/// <summary>
/// Represents a service for retrieving weather forecasts.
/// </summary>
/// <param name="loggerService">The logger instance for logging messages.</param>
internal sealed class WeatherForecastService(ILoggerService<WeatherForecastService> loggerService) : IWeatherForecastService
{
	private static readonly Random Random = new(Guid.NewGuid().GetHashCode());
	private static readonly string[] Summaries = ["Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"];

	private readonly ILoggerService<WeatherForecastService> _loggerService = loggerService;

	/// <summary>
	/// Retrieves a collection of weather forecasts.
	/// </summary>
	/// <param name="count">The number of forecasts to retrieve.</param>
	/// <returns>A collection of <see cref="WeatherForecast"/> objects.</returns>
	public IEnumerable<WeatherForecast> GetForecasts(int count)
	{
		IEnumerable<WeatherForecast> forecasts = Enumerable.Range(1, count).Select(index => new WeatherForecast
		{
			Date = DateTime.Now.AddDays(index),
			TemperatureC = Random.Next(-20, 55),
			Summary = Summaries[Random.Next(Summaries.Length)]
		});

		return forecasts;
	}
}
