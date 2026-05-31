using BB84.SourceGenerators.Attributes;

using DomainName.Application.Abstractions.Application.Providers;

namespace DomainName.Application.Providers;

/// <summary>
/// Represents a provider for environment-related operations. This class serves as
/// a wrapper around the <see cref="Environment"/> class, providing an abstraction
/// layer for environment operations within the application.
/// </summary>
[GenerateAbstraction(typeof(Environment), typeof(IEnvironmentProvider), typeof(EnvironmentProvider))]
internal sealed partial class EnvironmentProvider
{ }
