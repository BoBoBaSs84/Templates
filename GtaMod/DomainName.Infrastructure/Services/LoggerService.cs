using System.Runtime.CompilerServices;
using System.Text;

using DomainName.Application.Abstractions.Infrastructure.Services;

namespace DomainName.Infrastructure.Services;

/// <summary>
/// Represents the logger service implementation.
/// </summary>
internal sealed class LoggerService : ILoggerService
{
	private readonly string _logFilePath;

	/// <summary>
	/// Initializes a new instance of the <see cref="LoggerService"/> class.
	/// </summary>
	public LoggerService()
		=> _logFilePath = Path.Combine(Environment.CurrentDirectory, $"{nameof(DomainName)}.log");

	public void Critical(string message, [CallerMemberName] string callerName = "")
		=> LogToFile("FTL", callerName, message);

	public void Critical(string message, Exception exception, [CallerMemberName] string callerName = "")
		=> LogToFile("FTL", callerName, $"{message} - {exception}");

	public void Debug(string message, [CallerMemberName] string callerName = "")
		=> LogToFile("DBG", callerName, message);

	public void Information(string message, [CallerMemberName] string callerName = "")
		=> LogToFile("INF", callerName, message);

	public void Warning(string message, [CallerMemberName] string callerName = "")
		=> LogToFile("WRN", callerName, message);

	/// <summary>
	/// Logs the message content to the log file.
	/// </summary>
	/// <param name="type">The logger message type.</param>
	/// <param name="caller">The logger message caller.</param>
	/// <param name="message">The logger message itself.</param>
	private void LogToFile(string type, string caller, string message)
	{
		string content = $"{DateTime.Now:yyyy-MM-ddTHH:mm:ss.fff}\t[{type}]\t<{caller}> - {message}{Environment.NewLine}";
		File.AppendAllText(_logFilePath, content, Encoding.UTF8);
	}
}
