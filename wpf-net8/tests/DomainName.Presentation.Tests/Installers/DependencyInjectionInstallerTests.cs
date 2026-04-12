using DomainName.Presentation.Installers;

using Microsoft.Extensions.DependencyInjection;

namespace DomainName.Presentation.Tests.Installers;

[TestClass]
public sealed class DependencyInjectionInstallerTests : PresentationTestBase
{
	[TestMethod]
	public void RegisterPresentationServicesTest()
	{
		ServiceCollection services = new();

		services.RegisterPresentationServices();

		Assert.HasCount(4, services, "Expected 4 services to be registered.");
	}
}
