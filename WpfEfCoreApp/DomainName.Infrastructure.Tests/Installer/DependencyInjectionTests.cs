using DomainName.Infrastructure.Installer;

using Microsoft.Extensions.Configuration;
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
		Mock<IConfiguration> config = new Mock<IConfiguration>().SetupAllProperties();
		Mock<IHostEnvironment> env = new Mock<IHostEnvironment>().SetupAllProperties();
		env.Setup(x => x.EnvironmentName).Returns("Development");
		IServiceCollection services = new ServiceCollection();

		services.RegisterInfrastructureServices(config.Object, env.Object);

		Assert.AreEqual(30, services.Count);
	}

	[TestMethod]
	[TestCategory("DependencyInjection")]
	public void RegisterInfrastructureServicesForProductionTest()
	{
		Mock<IConfiguration> config = new Mock<IConfiguration>().SetupAllProperties();
		Mock<IHostEnvironment> env = new Mock<IHostEnvironment>().SetupAllProperties();
		env.Setup(x => x.EnvironmentName).Returns("Production");
		IServiceCollection services = new ServiceCollection();

		services.RegisterInfrastructureServices(config.Object, env.Object);

		Assert.AreEqual(18, services.Count);
	}
}
