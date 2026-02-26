using DomainName.Application.Abstractions.Application.Services;
using DomainName.Application.Abstractions.Presentation.Services;
using DomainName.Application.ViewModels;
using DomainName.Presentation.Forms;

using Microsoft.Extensions.Hosting;

using Moq;

namespace DomainName.Presentation.Tests.Forms;

[TestClass]
public sealed class MainFormTests
{
	private Mock<IEventService> _eventServiceMock = default!;
	private Mock<IHostEnvironment> _hostEnvironmentMock = default!;
	private Mock<INotificationService> _notificationSerivceMock = default!;
	private Mock<INavigationService> _navigationServiceMock = default!;

	[TestMethod]
	public void ConstructorShouldSetFieldsCorrectly()
	{
		MainForm mainForm;
		MainViewModel viewModel = GetMainViewModel();
		_navigationServiceMock = new();

		mainForm =
			new(_eventServiceMock.Object, _navigationServiceMock.Object, viewModel);

		Assert.IsNotNull(mainForm);
	}

	private MainViewModel GetMainViewModel()
	{
		_eventServiceMock = new();
		_hostEnvironmentMock = new();
		_hostEnvironmentMock.Setup(x => x.ApplicationName).Returns("TestApp");
		_hostEnvironmentMock.Setup(x => x.EnvironmentName).Returns("TestEnv");
		_notificationSerivceMock = new();

		return new(_eventServiceMock.Object, _hostEnvironmentMock.Object, _notificationSerivceMock.Object);
	}
}
