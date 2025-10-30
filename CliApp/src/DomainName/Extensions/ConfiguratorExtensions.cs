using System.Diagnostics.CodeAnalysis;

using DomainName.Commands;

using Spectre.Console.Cli;

namespace DomainName.Extensions;

/// <summary>
/// Represents extension methods for the <see cref="IConfigurator"/> interface.
/// </summary>
[SuppressMessage("Style", "IDE0058", Justification = "Not relevant here.")]
internal static class ConfiguratorExtensions
{
	/// <summary>
	/// Configures the commands.
	/// </summary>
	/// <param name="configurator">The configurator instance to use.</param>
	/// <returns>
	/// The same <see cref="IConfigurator"/> instance, so that multiple calls can be chained.
	/// </returns>
	internal static IConfigurator ConfigureCommands(this IConfigurator configurator)
	{
		configurator.AddCommand<WeatherForecastCommand>("forecasts")
			.WithDescription("Display local weather forecasts.")
			.WithExample(["forecasts", "5"]);

		return configurator;
	}
}
