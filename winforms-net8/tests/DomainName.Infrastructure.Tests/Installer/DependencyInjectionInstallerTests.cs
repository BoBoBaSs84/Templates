using DomainName.Infrastructure.Installer;

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
		Mock<IHostEnvironment> hostEnvironmentMock = new Mock<IHostEnvironment>()
			.SetupAllProperties();
		ServiceCollection services = new();

		services.RegisterInfrastructureServices(hostEnvironmentMock.Object);

		Assert.HasCount(30, services);
	}
}
