using System.Diagnostics.CodeAnalysis;

using DomainName.Application.Abstractions.Infrastructure.Providers;

namespace DomainName.Infrastructure.Providers;

/// <summary>
/// The implementation for the file provider contract.
/// </summary>
/// <inheritdoc cref="IFileProvider"/>
[ExcludeFromCodeCoverage]
internal sealed class FileProvider : IFileProvider
{
	public void Copy(string sourcePath, string destinationPath, bool overwrite = false)
		=> File.Copy(sourcePath, destinationPath, overwrite);

	public void Delete(string path)
		=> File.Delete(path);

	public bool Exists(string path)
		=> File.Exists(path);

	public void Move(string sourcePath, string destinationPath)
		=> File.Move(sourcePath, destinationPath);

	public byte[] ReadAllBytes(string path)
		=> File.ReadAllBytes(path);

	public string[] ReadAllLines(string path)
		=> File.ReadAllLines(path);

	public string ReadAllText(string path)
		=> File.ReadAllText(path);

	public void WriteAllBytes(string path, byte[] bytes)
		=> File.WriteAllBytes(path, bytes);

	public void WriteAllLines(string path, string[] contents)
		=> File.WriteAllLines(path, contents);

	public void WriteAllText(string path, string? contents)
		=> File.WriteAllText(path, contents);
}
