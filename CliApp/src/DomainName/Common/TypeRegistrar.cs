using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

using Spectre.Console.Cli;

namespace DomainName.Common;

/// <summary>
/// Registers types using the provided host builder.
/// </summary>
/// <param name="builder">The host builder to use for registrations.</param>
public sealed class TypeRegistrar(IHostBuilder builder) : ITypeRegistrar
{
	private readonly IHostBuilder _builder = builder;

	/// <inheritdoc/>
	public ITypeResolver Build()
		=> new TypeResolver(_builder.Build());

	/// <inheritdoc/>
	public void Register(Type service, Type implementation)
		=> _builder.ConfigureServices((_, services) => services.AddSingleton(service, implementation));

	/// <inheritdoc/>
	public void RegisterInstance(Type service, object implementation)
		=> _builder.ConfigureServices((_, services) => services.AddSingleton(service, implementation));

	/// <inheritdoc/>
	public void RegisterLazy(Type type, Func<object> func)
		=> _builder.ConfigureServices((context, services) => services.AddSingleton(type, factory => func()));
}
