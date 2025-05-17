using DomainName.Application.ViewModels;
using DomainName.Domain.Models;

namespace DomainName.Application.Tests.ViewModels;

[TestClass]
public sealed class AboutViewModelTests
{
	[TestMethod]
	public void ConstructorShouldSetPropertiesCorrect()
	{
		AboutModel model = new();

		AboutViewModel viewModel = new(model);

		Assert.AreEqual(model, viewModel.Model);
	}
}
