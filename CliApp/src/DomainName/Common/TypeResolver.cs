using Microsoft.Extensions.Hosting;

using Spectre.Console.Cli;

namespace DomainName.Common;

/// <summary>
/// Resolves types using the provided host's service provider.
/// </summary>
/// <param name="host">The host containing the service provider.</param>
public sealed class TypeResolver(IHost host) : ITypeResolver, IDisposable
{
	private readonly IHost _host = host;

	/// <inheritdoc/>
	public object? Resolve(Type? type)
		=> type is not null ? _host.Services.GetService(type) : null;

	/// <inheritdoc/>
	public void Dispose()
		=> _host.Dispose();
}
