using DomainName.Application.Abstractions.Infrastructure.Providers;

namespace DomainName.Application.Abstractions.Infrastructure.Services;

/// <summary>
/// Represents the provider service interface for accessing various providers.
/// </summary>
public interface IProviderService
{
	/// <summary>
	/// Gets the date and time provider.
	/// </summary>
	IDateTimeProvider DateTime { get; }

	/// <summary>
	/// Gets the directory provider.
	/// </summary>
	IDirectoryProvider Directory { get; }

	/// <summary>
	/// Gets the file provider.
	/// </summary>
	IFileProvider File { get; }

	/// <summary>
	/// Gets the path provider.
	/// </summary>
	IPathProvider Path { get; }
}
