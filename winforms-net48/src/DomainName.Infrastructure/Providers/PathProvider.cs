using System.Diagnostics.CodeAnalysis;

using DomainName.Application.Abstractions.Infrastructure.Providers;

namespace DomainName.Infrastructure.Providers;

/// <summary>
/// The implementation for the path provider contract.
/// </summary>
/// <inheritdoc cref="IPathProvider"/>
[ExcludeFromCodeCoverage]
internal sealed class PathProvider : IPathProvider
{
	public string Combine(params string[] paths)
		=> Path.Combine(paths);

	public string? GetDirectoryName(string? path)
		=> Path.GetDirectoryName(path);

	public string? GetExtension(string? path)
		=> Path.GetExtension(path);

	public string? GetFileName(string? path)
		=> Path.GetFileName(path);

	public string? GetFileNameWithoutExtension(string? path)
		=> Path.GetFileNameWithoutExtension(path);

	public string GetFullPath(string path)
		=> Path.GetFullPath(path);

	public string? GetPathRoot(string? path)
		=> Path.GetPathRoot(path);

	public string GetRandomFileName()
		=> Path.GetRandomFileName();

	public string GetTempFileName()
		=> Path.GetTempFileName();

	public string GetTempPath()
		=> Path.GetTempPath();

	public bool HasExtension(string? path)
		=> Path.HasExtension(path);

	public bool IsPathRooted(string? path)
		=> Path.IsPathRooted(path);
}
