using DomainName.Application.Abstractions.Application.Providers;
using DomainName.Application.Abstractions.Application.Services;
using DomainName.Application.Providers;

namespace DomainName.Application.Services;

/// <summary>
/// Represents a service that provides access to various system-related providers,
/// such as date and time, directory, file, and path providers.
/// </summary>
internal sealed class SystemService : ISystemService
{
	private readonly Lazy<IDateTimeProvider> _dateTimeProvider = new(() => new DateTimeProvider());
	private readonly Lazy<IDirectoryProvider> _directoryProvider = new(() => new DirectoryProvider());
	private readonly Lazy<IFileProvider> _fileProvider = new(() => new FileProvider());
	private readonly Lazy<IPathProvider> _pathProvider = new(() => new PathProvider());

	public IDateTimeProvider DateTime => _dateTimeProvider.Value;
	public IDirectoryProvider Directory => _directoryProvider.Value;
	public IFileProvider File => _fileProvider.Value;
	public IPathProvider Path => _pathProvider.Value;
}
