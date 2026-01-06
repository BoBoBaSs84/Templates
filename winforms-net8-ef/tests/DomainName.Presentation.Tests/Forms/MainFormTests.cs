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
	private Mock<IHostEnvironment> _hostEnvironmentMock = default!;
	private Mock<IUserService> _userServiceMock = default!;
	private Mock<INavigationService> _navigationServiceMock = default!;
	private Mock<IServiceProvider> _serviceProviderMock = default!;
	private Mock<IEventService> _eventServiceMock = default!;

	[TestMethod]
	public void ConstructorShouldSetFieldsCorrectly()
	{
		MainViewModel mainViewModel = GetMainViewModel();
		_navigationServiceMock = new();
		_serviceProviderMock = new();
		_eventServiceMock = new();

		using MainForm form = new(_navigationServiceMock.Object, _serviceProviderMock.Object, _eventServiceMock.Object, mainViewModel);

		Assert.AreEqual($"{mainViewModel.ApplicationName} - {mainViewModel.EnvironmentName}", form.Text);
	}

	private MainViewModel GetMainViewModel()
	{
		_hostEnvironmentMock = new();
		_hostEnvironmentMock.Setup(x => x.ApplicationName).Returns("TestApp");
		_hostEnvironmentMock.Setup(x => x.EnvironmentName).Returns("TestEnv");
		_userServiceMock = new();
		_userServiceMock.Setup(x => x.Domain).Returns("TestDomain");
		_userServiceMock.Setup(x => x.Name).Returns("TestUser");
		_userServiceMock.Setup(x => x.Machine).Returns("TestMachine");

		MainViewModel viewModel = new(_hostEnvironmentMock.Object, _userServiceMock.Object);
		return viewModel;
	}
}
