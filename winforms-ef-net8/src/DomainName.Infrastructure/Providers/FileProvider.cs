﻿using System.Diagnostics.CodeAnalysis;

using DomainName.Application.Abstractions.Infrastructure.Providers;

namespace DomainName.Infrastructure.Providers;

/// <summary>
/// The implementation for the file provider contract.
/// </summary>
/// <inheritdoc cref="IFileProvider"/>
[ExcludeFromCodeCoverage(Justification = "This class is a simple wrapper around the System.IO.File class.")]
internal sealed class FileProvider : IFileProvider
{
	public void Copy(string sourcePath, string destinationPath, bool overwrite = false)
		=> File.Copy(sourcePath, destinationPath, overwrite);

	public void Delete(string path)
		=> File.Delete(path);

	public bool Exists(string path)
		=> File.Exists(path);

	public void Move(string sourcePath, string destinationPath, bool overwrite = false)
		=> File.Move(sourcePath, destinationPath, overwrite);

	public byte[] ReadAllBytes(string path)
		=> File.ReadAllBytes(path);

	public Task<byte[]> ReadAllBytesAsync(string path, CancellationToken cancellationToken = default)
		=> File.ReadAllBytesAsync(path, cancellationToken);

	public string[] ReadAllLines(string path)
		=> File.ReadAllLines(path);

	public Task<string[]> ReadAllLinesAsync(string path, CancellationToken cancellationToken = default)
		=> File.ReadAllLinesAsync(path, cancellationToken);

	public string ReadAllText(string path)
		=> File.ReadAllText(path);

	public Task<string> ReadAllTextAsync(string path, CancellationToken cancellationToken = default)
		=> File.ReadAllTextAsync(path, cancellationToken);

	public void WriteAllBytes(string path, byte[] bytes)
		=> File.WriteAllBytes(path, bytes);

	public Task WriteAllBytesAsync(string path, byte[] bytes, CancellationToken cancellationToken = default)
		=> File.WriteAllBytesAsync(path, bytes, cancellationToken);

	public void WriteAllLines(string path, string[] contents)
		=> File.WriteAllLines(path, contents);

	public Task WriteAllLinesAsync(string path, string[] contents, CancellationToken cancellationToken = default)
		=> File.WriteAllLinesAsync(path, contents, cancellationToken);

	public void WriteAllText(string path, string? contents)
		=> File.WriteAllText(path, contents);

	public Task WriteAllTextAsync(string path, string? contents, CancellationToken cancellationToken = default)
		=> File.WriteAllTextAsync(path, contents, cancellationToken);
}
