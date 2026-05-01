using DomainName.Application.Abstractions.Application.ViewModels;
using DomainName.Application.Services;
using DomainName.Application.ViewModels.Base;

namespace DomainName.Application.Tests.Services;

[TestClass]
public sealed class NavigationServiceTests : ApplicationTestBase
{
	[TestMethod]
	public void NavigateToShouldNavigateToTheSpecifiedViewModel()
	{
		Func<Type, ViewModelBase> viewModelFactory = new(type => new TestViewModel());
		NavigationService navigationService = new(viewModelFactory);

		navigationService.NavigateTo<TestViewModel>();

		Assert.IsNotNull(navigationService.CurrentView);
		Assert.IsInstanceOfType<TestViewModel>(navigationService.CurrentView);
	}

	private sealed class TestViewModel : ViewModelBase, INavigatable
	{ }
}
