using DomainName.Domain.Enumerators;

namespace DomainName.Application.Events;

/// <summary>
/// Represents an event that is raised when the log level setting is changed in the application,
/// allowing subscribers to react to changes in logging verbosity and adjust their behavior accordingly.
/// </summary>
/// <param name="logLevel">The new log level that has been set.</param>
public sealed class LogLevelChangedEvent(LoggingLevel logLevel)
{
	/// <summary>
	/// Gets the log level that has been changed to, which determines the verbosity of logging output.
	/// </summary>
	public LoggingLevel LogLevel { get; } = logLevel;
}
