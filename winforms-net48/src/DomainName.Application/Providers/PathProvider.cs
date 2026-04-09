using System.Diagnostics.CodeAnalysis;

using BB84.SourceGenerators.Attributes;

using DomainName.Application.Abstractions.Application.Providers;

namespace DomainName.Application.Providers;

/// <summary>
/// Represents the implementation for the path provider contract.
/// </summary>
/// <remarks>
/// Abstraction is generated for the <see cref="Path"/> class, which provides methods for manipulating path strings.
/// This allows for easier testing and separation of concerns in the application, as the path-related functionality
/// can be abstracted away and mocked during unit testing.
/// </remarks>
[ExcludeFromCodeCoverage]
[GenerateAbstraction(typeof(Path), typeof(IPathProvider), typeof(PathProvider))]
internal sealed partial class PathProvider : IPathProvider
{ }
