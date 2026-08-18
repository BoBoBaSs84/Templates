using DomainName.Application.Abstractions.Services;
using DomainName.Application.ViewModels;

using Microsoft.Extensions.Hosting;

using Moq;

namespace DomainName.Application.Tests.ViewModels;

[TestClass]
public sealed class MainViewModelTests
{
	[TestMethod]
	public void ConstructorShouldSetPropertiesCorrect()
	{
		Mock<IHostEnvironment> hostEnvironmentMock = new();
		_ = hostEnvironmentMock.Setup(x => x.ApplicationName).Returns("TestApp");
		_ = hostEnvironmentMock.Setup(x => x.EnvironmentName).Returns("TestEnv");
		Mock<IUserService> userServiceMock = new();
		_ = userServiceMock.Setup(x => x.Domain).Returns("TestDomain");
		_ = userServiceMock.Setup(x => x.Name).Returns("TestUser");
		_ = userServiceMock.Setup(x => x.Machine).Returns("TestMachine");

		MainViewModel viewModel = new(hostEnvironmentMock.Object, userServiceMock.Object);

		Assert.AreEqual("TestApp", viewModel.ApplicationName);
		Assert.AreEqual("TestEnv", viewModel.EnvironmentName);
		Assert.AreEqual("TestDomain\\TestUser@TestMachine", viewModel.CurrentUser);
	}
}
