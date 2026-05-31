using System.ComponentModel;

namespace DomainName.Domain.Abstractions.Settings;

/// <summary>
/// Represents an abstraction of the general settings for the modification.
/// </summary>
public interface IGeneralSettings : INotifyPropertyChanged
{
	/// <summary>
	/// Gets or sets a value indicating whether the modification is in debug mode.
	/// </summary>
	bool IsDebugMode { get; set; }

	/// <summary>
	/// Gets or sets a value indicating whether logging is enabled for the modification.
	/// </summary>
	bool IsLoggingEnabled { get; set; }
}
