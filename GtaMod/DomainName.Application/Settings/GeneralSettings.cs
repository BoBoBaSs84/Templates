using BB84.SourceGenerators.Attributes;

using DomainName.Domain.Abstractions.Settings;
using DomainName.Domain.Models.Base;

namespace DomainName.Application.Settings;

/// <summary>
/// Represents the general settings for the modification.
/// </summary>
public sealed partial class GeneralSettings : BindableBase, IGeneralSettings
{
	private bool _isDebugMode;
	private bool _isLoggingEnabled = true;

	/// <inheritdoc/>
	[GenerateIniFileValue]
	public bool IsDebugMode
	{
		get => _isDebugMode;
		set => SetProperty(ref _isDebugMode, value, nameof(IsDebugMode));
	}

	/// <inheritdoc/>
	[GenerateIniFileValue]
	public bool IsLoggingEnabled
	{
		get => _isLoggingEnabled;
		set => SetProperty(ref _isLoggingEnabled, value, nameof(IsLoggingEnabled));
	}
}
