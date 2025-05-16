using DomainName.Domain.Models;

namespace DomainName.Domain.Tests.Models;

[TestClass]
public sealed class AboutModelTests : DomainTestBase
{
	[TestMethod]
	[TestCategory("Constructor")]
	public void AboutModelTest()
	{
		AboutModel? model;

		model = new();

		Assert.IsNotNull(model);
		Assert.IsNotNull(model.Title);
		Assert.IsNotNull(model.Version);
		Assert.IsNotNull(model.Comments);
		Assert.IsNotNull(model.Company);
		Assert.IsNotNull(model.Copyright);
		Assert.IsNotNull(model.FrameworkName);
		Assert.IsNotNull(model.Repository);
	}
}
