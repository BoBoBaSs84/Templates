using DomainName.Application.ViewModels;
using DomainName.Domain.Models;

namespace DomainName.Application.Tests.ViewModels;

[TestClass]
public sealed class AboutViewModelTests : ApplicationTestBase
{
	[TestMethod]
	[TestCategory("Constructor")]
	public void AboutViewModelTest()
	{
		AboutViewModel? viewModel;
		AboutModel model = new();
		
		viewModel = new(model);

		Assert.IsNotNull(viewModel);
		Assert.AreEqual(model, viewModel.Model);
	}
}
