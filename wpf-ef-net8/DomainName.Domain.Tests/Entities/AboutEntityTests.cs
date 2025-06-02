using DomainName.Domain.Models;

namespace DomainName.Domain.Tests.Entities;

[TestClass]
public sealed class AboutEntityTests : DomainTestBase
{
	[TestMethod]
	[TestCategory("Constructor")]
	public void AboutEntityTest()
	{
		AboutModel? entity;

		entity = new();

		Assert.IsNotNull(entity);
		Assert.IsNotNull(entity.Title);
		Assert.IsNotNull(entity.Version);
		Assert.IsNotNull(entity.Comments);
		Assert.IsNotNull(entity.Company);
		Assert.IsNotNull(entity.Copyright);
		Assert.IsNotNull(entity.FrameworkName);
		Assert.IsNotNull(entity.Repository);
	}
}
