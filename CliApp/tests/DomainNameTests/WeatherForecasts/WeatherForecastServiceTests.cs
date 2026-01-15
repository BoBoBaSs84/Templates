using DomainName.Models;
using DomainName.Services;

namespace DomainNameTests.WeatherForecasts;

[TestClass]
public sealed class WeatherForecastServiceTests
{
	[TestMethod]
	public void GetForecastsShouldReturnFiveResultsWhenFiveIsOmited()
	{
		int expected = 5;
		WeatherForecastService sut = new();

		IEnumerable<WeatherForecast> result = sut.GetForecasts(expected);

		Assert.HasCount(expected, result);
	}
}
