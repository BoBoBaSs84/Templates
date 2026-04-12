using DomainName.Application.Installers;

using Microsoft.Extensions.DependencyInjection;

namespace DomainName.Application.Tests.Installer;

[TestClass]
public sealed class DependencyInjectionInstallerTests : ApplicationTestBase
{
	[TestMethod]
	public void RegisterApplicationServicesTest()
	{
		ServiceCollection services = new();

		services.RegisterApplicationServices();

		Assert.HasCount(6, services);
	}
}
