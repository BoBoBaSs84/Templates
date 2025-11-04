using DomainName.Application.Abstractions.Infrastructure.Providers;
using DomainName.Application.Abstractions.Infrastructure.Services;
using DomainName.Infrastructure.Providers;

namespace DomainName.Infrastructure.Services;

/// <summary>
/// Represents the provider service.
/// </summary>
internal sealed class ProviderService : IProviderService
{
	private readonly Lazy<IDateTimeProvider> _dateTimeProvider;
	private readonly Lazy<IDirectoryProvider> _directoryProvider;
	private readonly Lazy<IFileProvider> _fileProvider;
	private readonly Lazy<IPathProvider> _pathProvider;

	/// <summary>
	/// Initializes a new instance of the <see cref="ProviderService"/> class.
	/// </summary>
	private ProviderService()
	{
		_dateTimeProvider = new(() => new DateTimeProvider());
		_directoryProvider = new(() => new DirectoryProvider());
		_fileProvider = new(() => new FileProvider());
		_pathProvider = new(() => new PathProvider());
	}

	public IDateTimeProvider DateTime => _dateTimeProvider.Value;
	public IDirectoryProvider Directory => _directoryProvider.Value;
	public IFileProvider File => _fileProvider.Value;
	public IPathProvider Path => _pathProvider.Value;
}
