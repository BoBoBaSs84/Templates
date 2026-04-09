using DomainName.Domain.Installer;

using Microsoft.Extensions.DependencyInjection;

namespace DomainName.Domain.Tests.Installer;

[TestClass]
public sealed class DependencyInjectionInstallerTests
{
	[TestMethod]
	public void RegisterDomainServicesTest()
	{
		ServiceCollection services = new();

		services.RegisterDomainServices();

		Assert.AreEqual(1, services.Count);
	}
}
