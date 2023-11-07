using Microsoft.Extensions.DependencyInjection;

using Spectre.Console.Cli;

namespace DomainName.Infrastructure;

public sealed class TypeResolver : ITypeResolver, IDisposable
{
	private readonly IServiceProvider _provider;

	public TypeResolver(IServiceProvider provider)
		=> _provider = provider;

	public object Resolve(Type type)
		=> _provider.GetRequiredService(type);

	public void Dispose()
	{
		if (_provider is IDisposable disposable)
		{
			disposable.Dispose();
		}
	}
}
