using System.Diagnostics.CodeAnalysis;

using BB84.SourceGenerators.Attributes;

using DomainName.Application.Abstractions.Application.Providers;

using GTA;

namespace DomainName.Application.Providers;

/// <summary>
/// Represents a provider for audio-related functionalities in the application.
/// </summary>
[ExcludeFromCodeCoverage]
[GenerateAbstraction(typeof(Audio), typeof(IAudioProvider), typeof(AudioProvider))]
internal sealed partial class AudioProvider : IAudioProvider
{ }
