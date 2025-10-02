using DomainName.Application.Services;

namespace DomainName.Application.Tests.Services;

[TestClass]
public sealed class UserServiceTests : ApplicationTestBase
{
	[TestMethod]
	[TestCategory("Constructor")]
	public void UserServiceTest()
	{
		UserService? service;

		service = new UserService();

		Assert.IsNotNull(service);
		Assert.AreNotEqual(string.Empty, service.Domain);
		Assert.AreNotEqual(string.Empty, service.Machine);
		Assert.AreNotEqual(string.Empty, service.User);
	}
}
