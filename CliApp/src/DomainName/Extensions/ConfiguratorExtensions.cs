using System.Diagnostics.CodeAnalysis;

using DomainName.Commands;

using Spectre.Console.Cli;

namespace DomainName.Extensions;

/// <summary>
/// The configurator extensions class.
/// </summary>
[SuppressMessage("Style", "IDE0058", Justification = "Not relevant here.")]
internal static class ConfiguratorExtensions
{
	internal static IConfigurator ConfigureCommands(this IConfigurator configurator)
	{
		configurator.AddCommand<WeatherForecastCommand>("forecasts")
			.WithDescription("Display local weather forecasts.")
			.WithExample(["forecasts", "5"]);

		return configurator;
	}
}
