using DomainName.Application.Abstractions.Application.Services;
using DomainName.Application.Abstractions.Presentation.Services;
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
		Mock<IEventService> eventServiceMock = new();
		Mock<IHostEnvironment> hostEnvironmentMock = new();
		hostEnvironmentMock.Setup(x => x.ApplicationName).Returns("TestApp");
		hostEnvironmentMock.Setup(x => x.EnvironmentName).Returns("TestEnv");
		Mock<INotificationService> notificationSerivceMock = new();

		MainViewModel viewModel = new(eventServiceMock.Object, hostEnvironmentMock.Object, notificationSerivceMock.Object);

		Assert.AreEqual("TestApp - TestEnv", viewModel.ApplicationTitle);
		Assert.AreEqual(string.Empty, viewModel.StatusText);
		Assert.AreEqual(0, viewModel.ProgressBarValue);
		Assert.AreEqual(100, viewModel.ProgressBarMaximum);
		Assert.AreEqual(0, viewModel.ProgressBarMinimum);
		Assert.IsFalse(viewModel.ProgressBarVisible);
	}
}
