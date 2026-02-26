using DomainName.Application.ViewModels;
using DomainName.Presentation.Forms;

namespace DomainName.Presentation.Tests.Forms;

[TestClass]
public sealed class AboutFormTests : PresentationTestBase
{
	[TestMethod]
	public void ConstructorShouldSetFieldsCorrectly()
	{
		AboutViewModel viewModel = new();

		using AboutForm form = new(viewModel);

		Assert.AreNotEqual(viewModel.Title, string.Empty);
		Assert.AreNotEqual(viewModel.Version, string.Empty);
		Assert.AreNotEqual(viewModel.Company, string.Empty);
		Assert.AreNotEqual(viewModel.Copyright, string.Empty);
		Assert.AreNotEqual(viewModel.FrameworkName, string.Empty);
		Assert.AreNotEqual(viewModel.Repository, string.Empty);
		Assert.AreNotEqual(viewModel.Comments, string.Empty);
	}
}
