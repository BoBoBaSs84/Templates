using System.Diagnostics.CodeAnalysis;

using BB84.SourceGenerators.Attributes;

using DomainName.Application.Abstractions.Application.Providers;

namespace DomainName.Application.Providers;

/// <summary>
/// The implementation for the directory provider contract.
/// </summary>
/// <inheritdoc cref="IDirectoryProvider"/>
[ExcludeFromCodeCoverage]
[GenerateAbstraction(typeof(Directory), typeof(IDirectoryProvider), typeof(DirectoryProvider))]
internal sealed partial class DirectoryProvider : IDirectoryProvider
{ }
