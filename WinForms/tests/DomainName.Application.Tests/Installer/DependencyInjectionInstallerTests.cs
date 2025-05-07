using DomainName.Application.Installer;

using Microsoft.Extensions.DependencyInjection;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DomainName.Application.Tests.Installer;

[TestClass]
public class DependencyInjectionInstallerTests
{
	[TestMethod]
	public void RegisterApplicationServicesTest()
	{
		ServiceCollection services = new();

		services.RegisterApplicationServices();

		Assert.AreEqual(30, services.Count);
	}
}
