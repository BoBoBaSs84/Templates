using DomainName.Application.Interfaces.Infrastructure.Services;
using DomainName.Infrastructure.Services;

namespace DomainName.Infrastructure.Factories;

public static partial class InfrastructureFactory
{
	/// <summary>
	/// Returns the logger service sigleton instance.
	/// </summary>
	/// <returns>The logger service sigleton instance.</returns>
	public static ILoggerService GetLoggerService() => LoggerService.Instance;
}
