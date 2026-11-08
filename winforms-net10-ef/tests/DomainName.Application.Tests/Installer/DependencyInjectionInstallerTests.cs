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

		_ = services.RegisterApplicationServices();

		Assert.HasCount(6, services);
	}
}
