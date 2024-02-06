namespace DomainName.Domain.Interfaces.Models.Base;

/// <summary>
/// The concurrency model interface.
/// </summary>
public interface IConcurrencyModel
{
	/// <summary>
	/// The current timestamp or row version.
	/// </summary>
	byte[] Timestamp { get; }
}
