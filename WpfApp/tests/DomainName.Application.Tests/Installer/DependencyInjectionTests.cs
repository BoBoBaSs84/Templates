using DomainName.Application.Installer;

using Microsoft.Extensions.DependencyInjection;

namespace DomainName.Application.Tests.Installer;

[TestClass]
[SuppressMessage("Style", "IDE0058", Justification = "Not relevant here, unit test.")]
public sealed class DependencyInjectionTests : ApplicationTestBase
{
	[TestMethod]
	[TestCategory("DependencyInjection")]
	public void RegisterApplicationServicesTest()
	{
		ServiceCollection services = new();

		services.RegisterApplicationServices();

		Assert.AreEqual(4, services.Count);
	}
}
