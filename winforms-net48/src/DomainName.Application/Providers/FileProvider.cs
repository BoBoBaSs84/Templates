using System.Diagnostics.CodeAnalysis;

using BB84.SourceGenerators.Attributes;

using DomainName.Application.Abstractions.Application.Providers;

namespace DomainName.Application.Providers;

/// <summary>
/// The implementation for the file provider contract.
/// </summary>
/// <inheritdoc cref="IFileProvider"/>
[ExcludeFromCodeCoverage]
[GenerateAbstraction(typeof(File), typeof(IFileProvider), typeof(FileProvider))]
internal sealed partial class FileProvider : IFileProvider
{ }
