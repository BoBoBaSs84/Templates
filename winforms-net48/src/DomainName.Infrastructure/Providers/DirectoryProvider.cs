using System.Diagnostics.CodeAnalysis;

using DomainName.Application.Abstractions.Infrastructure.Providers;

namespace DomainName.Infrastructure.Providers;

/// <summary>
/// The implementation for the directory provider contract.
/// </summary>
/// <inheritdoc cref="IDirectoryProvider"/>
[ExcludeFromCodeCoverage]
internal sealed class DirectoryProvider : IDirectoryProvider
{
	public void CreateDirectory(string path)
		=> Directory.CreateDirectory(path);

	public void Delete(string path, bool recursive = false)
		=> Directory.Delete(path, recursive);

	public bool Exists(string path)
		=> Directory.Exists(path);

	public string[] GetFiles(string path, string searchPattern = "*.*", SearchOption searchOption = SearchOption.TopDirectoryOnly)
		=> Directory.GetFiles(path, searchPattern, searchOption);

	public string[] GetDirectories(string path, string searchPattern = "*.*", SearchOption searchOption = SearchOption.TopDirectoryOnly)
		=> Directory.GetDirectories(path, searchPattern, searchOption);

	public void Move(string sourceDirName, string destDirName)
		=> Directory.Move(sourceDirName, destDirName);

	public string[] GetLogicalDrives()
		=> Directory.GetLogicalDrives();
}
