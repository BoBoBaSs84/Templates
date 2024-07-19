using DomainName.Application.Services;
using DomainName.Application.ViewModels;

namespace DomainName.Application.Tests.Services;

[TestClass]
public sealed class NavigationServiceTests : ApplicationTestBase
{
	[TestMethod]
	[TestCategory("Constructor")]
	public void NavigationServiceTest()
	{
		NavigationService? service;
		AboutViewModel viewModel = new(new());

		service = new(t => viewModel);

		Assert.IsNotNull(service);
	}

	[TestMethod]
	[TestCategory("Method")]
	public void NavigateToTest()
	{
		AboutViewModel viewModel = new(new());
		NavigationService service = new(t => viewModel);

		service.NavigateTo<AboutViewModel>();

		Assert.IsInstanceOfType(service.CurrentView, typeof(AboutViewModel));
	}
}
