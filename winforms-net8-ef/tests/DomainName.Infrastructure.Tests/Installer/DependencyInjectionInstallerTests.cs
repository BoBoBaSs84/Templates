using DomainName.Infrastructure.Installer;

using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

using Moq;

namespace DomainName.Infrastructure.Tests.Installer;

[TestClass]
public class DependencyInjectionInstallerTests
{
	[TestMethod]
	public void RegisterInfrastructureServicesTest()
	{
		Mock<IConfiguration> configurationMock = new Mock<IConfiguration>()
			.SetupAllProperties();
		Mock<IHostEnvironment> hostEnvironmentMock = new Mock<IHostEnvironment>()
			.SetupAllProperties();
		ServiceCollection services = new();

		services.RegisterInfrastructureServices(configurationMock.Object, hostEnvironmentMock.Object);

		Assert.AreEqual(35, services.Count);
	}
}
