using DomainName.Application.ViewModels;

namespace DomainName.Application.Tests.ViewModels;

[TestClass]
public sealed class AboutViewModelTests
{
	[TestMethod]
	public void ConstructorShouldSetPropertiesCorrect()
	{
		AboutViewModel? viewModel;

		viewModel = new();

		Assert.IsNotNull(viewModel);
		Assert.AreNotEqual(string.Empty, viewModel.Title);
		Assert.AreNotEqual(string.Empty, viewModel.Version);
		Assert.AreNotEqual(string.Empty, viewModel.Comments);
		Assert.AreNotEqual(string.Empty, viewModel.Company);
		Assert.AreNotEqual(string.Empty, viewModel.Copyright);
		Assert.AreNotEqual(string.Empty, viewModel.FrameworkName);
		Assert.AreNotEqual(string.Empty, viewModel.Repository);
	}
}
