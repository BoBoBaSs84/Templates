﻿using System.IO;

namespace DomainName.Application.Abstractions.Infrastructure.Providers;

/// <summary>
/// This interface defines a contract for directory provider.
/// </summary>
/// <remarks>
/// Serves as an abstraction for the <see cref="Directory"/> operations.
/// </remarks>
public interface IDirectoryProvider
{
	/// <inheritdoc cref="Directory.CreateDirectory(string)"/>
	void CreateDirectory(string path);

	/// <inheritdoc cref="Directory.Delete(string, bool)"/>
	void Delete(string path, bool recursive = false);

	/// <inheritdoc cref="Directory.Exists(string)"/>
	bool Exists(string path);

	/// <inheritdoc cref="Directory.GetDirectories(string, string, SearchOption)"/>
	string[] GetDirectories(string path, string searchPattern = "*.*", SearchOption searchOption = SearchOption.TopDirectoryOnly);

	/// <inheritdoc cref="Directory.GetFiles(string, string, SearchOption)"/>
	string[] GetFiles(string path, string searchPattern = "*.*", SearchOption searchOption = SearchOption.TopDirectoryOnly);

	/// <inheritdoc cref="Directory.Move(string, string)"/>
	void Move(string sourceDirName, string destDirName);

	/// <inheritdoc cref="Directory.GetLogicalDrives()"/>
	string[] GetLogicalDrives();
}
