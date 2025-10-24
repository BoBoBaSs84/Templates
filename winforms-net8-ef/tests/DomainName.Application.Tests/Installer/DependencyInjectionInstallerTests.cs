using DomainName.Application.Installer;

using Microsoft.Extensions.DependencyInjection;

namespace DomainName.Application.Tests.Installer;

[TestClass]
public class DependencyInjectionInstallerTests
{
	[TestMethod]
	public void RegisterApplicationServicesTest()
	{
		ServiceCollection services = new();

		services.RegisterApplicationServices();

		Assert.AreEqual(3, services.Count);
	}
}
