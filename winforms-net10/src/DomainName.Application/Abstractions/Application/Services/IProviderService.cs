using DomainName.Application.Abstractions.Application.Providers;

namespace DomainName.Application.Abstractions.Application.Services;

/// <summary>
/// Represents a service interface that provides access to external providers.
/// </summary>
public interface IProviderService
{
	/// <summary>
	/// Gets the provider for accessing date and time operations.
	/// </summary>
	IDateTimeProvider DateTime { get; }

	/// <summary>
	/// Gets the provider for accessing directory operations.
	/// </summary>
	IDirectoryProvider Directory { get; }

	/// <summary>
	/// Gets the provider for accessing environment operations.
	/// </summary>
	IEnvironmentProvider Environment { get; }

	/// <summary>
	/// Gets the provider for accessing file operations.
	/// </summary>
	IFileProvider File { get; }

	/// <summary>
	/// Gets the provider for accessing path operations.
	/// </summary>
	IPathProvider Path { get; }
}
