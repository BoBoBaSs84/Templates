using DomainName.Presentation.Installer;

using Microsoft.Extensions.DependencyInjection;

namespace DomainName.Presentation.Tests.Installer;

[TestClass]
public sealed class DependencyInjectionInstallerTests
{
	[TestMethod]
	public void RegisterPresentationServicesTest()
	{
		ServiceCollection services = new();

		services.RegisterPresentationServices();

		Assert.HasCount(7, services);
	}
}
