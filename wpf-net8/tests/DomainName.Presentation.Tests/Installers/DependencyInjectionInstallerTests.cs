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

		Assert.AreEqual(4, services.Count, "Expected 3 services to be registered.");
	}
}
