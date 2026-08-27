using DomainName.Application.Settings;
using DomainName.Infrastructure.Installers;

using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

using Moq;

namespace DomainName.Infrastructure.Tests.Installer;

[TestClass]
public sealed class DependencyInjectionInstallerTests : InfrastructureTestBase
{
	private readonly Mock<IHostEnvironment> _hostEnvironmentMock;

	public DependencyInjectionInstallerTests()
	{
		_hostEnvironmentMock = new();
	}


	[TestMethod]
	[TestCategory("DependencyInjection")]
	public void RegisterInfrastructureServicesForDevelopmentTest()
	{
		_hostEnvironmentMock.Setup(x => x.EnvironmentName).Returns("Development");
		ServiceCollection services = new();

		services.AddSingleton<ApplicationSettings>()
			.RegisterInfrastructureServices(_hostEnvironmentMock.Object);

		Assert.HasCount(53, services);
	}

	[TestMethod]
	[TestCategory("DependencyInjection")]
	public void RegisterInfrastructureServicesForProductionTest()
	{
		_hostEnvironmentMock.Setup(x => x.EnvironmentName).Returns("Production");
		ServiceCollection services = new();

		services.AddSingleton<ApplicationSettings>()
			.RegisterInfrastructureServices(_hostEnvironmentMock.Object);

		Assert.HasCount(41, services);
	}
}
