using DomainName.Application.Interfaces.Application.Services;
using DomainName.Application.ViewModels;

using Moq;

namespace DomainName.Application.Tests.ViewModels;

[TestClass]
public sealed class MainViewModelTests : ApplicationTestBase
{
	[TestMethod]
	[TestCategory("Constructor")]
	public void MainViewModelTest()
	{
		Mock<INavigationService> navigationServiceMock = new();

		MainViewModel viewModel = new(navigationServiceMock.Object);

		Assert.IsNotNull(viewModel);
		Assert.AreEqual(navigationServiceMock.Object, viewModel.NavigationService);
	}
}
