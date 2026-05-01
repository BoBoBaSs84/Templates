using BB84.Notifications.Commands;

using DomainName.Application.Abstractions.Application.Services;
using DomainName.Application.Abstractions.Presentation.Services;
using DomainName.Application.ViewModels;

using Microsoft.Extensions.Hosting;

using Moq;

namespace DomainName.Application.Tests.ViewModels;

[TestClass]
public sealed class MainViewModelTests : ApplicationTestBase
{
	private readonly Mock<IEventService> _eventServiceMock;
	private readonly Mock<IHostEnvironment> _hostEnvironmentMock;
	private readonly Mock<INavigationService> _navigationServiceMock;
	private readonly Mock<INotificationService> _notificationServiceMock;

	public MainViewModelTests()
	{
		_eventServiceMock = new();
		_hostEnvironmentMock = new();
		_navigationServiceMock = new();
		_notificationServiceMock = new();
	}

	[TestMethod]
	public void MainViewModelConstructorShouldSetUpAllPropertiesCorrectly()
	{
		string expectedApplicationName = "TestApp";
		string expectedEnvironmentName = "TestEnv";
		_hostEnvironmentMock.Setup(x => x.ApplicationName).Returns(expectedApplicationName);
		_hostEnvironmentMock.Setup(x => x.EnvironmentName).Returns(expectedEnvironmentName);

		MainViewModel viewModel = new(_eventServiceMock.Object, _hostEnvironmentMock.Object, _navigationServiceMock.Object, _notificationServiceMock.Object);

		Assert.AreEqual($"{expectedApplicationName} - {expectedEnvironmentName}", viewModel.ApplicationTitle, "ApplicationTitle should be set correctly.");
		Assert.AreEqual(string.Empty, viewModel.ApplicationStatus, "ApplicationStatus should be empty.");
		Assert.AreEqual(_navigationServiceMock.Object, viewModel.NavigationService, "NavigationService should be set correctly.");
		Assert.IsInstanceOfType<ActionCommand>(viewModel.ShowAboutCommand, "AboutCommand should be of type ActionCommand.");
		Assert.IsInstanceOfType<ActionCommand>(viewModel.ExitApplicationCommand, "ExitCommand should be of type ActionCommand.");
	}
}
