using DomainName.Infrastructure.Installer;

using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

using Moq;

namespace DomainName.Infrastructure.Tests.Installer;

[TestClass]
[SuppressMessage("Style", "IDE0058", Justification = "Not relevant here, unit test.")]
public class DependencyInjectionTests : InfrastructureTestBase
{
	[TestMethod]
	[TestCategory("DependencyInjection")]
	public void RegisterInfrastructureServicesForDevelopmentTest()
	{
		Mock<IHostEnvironment> env = new Mock<IHostEnvironment>()
			.SetupAllProperties();
		env.Setup(x => x.EnvironmentName).Returns("Development");
		IServiceCollection services = new ServiceCollection();

		services.RegisterInfrastructureServices(env.Object);

		Assert.AreEqual(24, services.Count);
	}

	[TestMethod]
	[TestCategory("DependencyInjection")]
	public void RegisterInfrastructureServicesForProductionTest()
	{
		Mock<IHostEnvironment> env = new Mock<IHostEnvironment>()
			.SetupAllProperties();
		env.Setup(x => x.EnvironmentName).Returns("Production");
		IServiceCollection services = new ServiceCollection();

		services.RegisterInfrastructureServices(env.Object);

		Assert.AreEqual(12, services.Count);
	}
}
