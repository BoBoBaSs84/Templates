using DomainName.Application.Providers;
using DomainName.Application.Services;

namespace DomainName.Application.Tests.Services;

[TestClass]
public sealed class ProviderServiceTests : ApplicationTestBase
{
	[TestMethod]
	public void ProviderServiceConstructorShouldSetUpAllProperties()
	{
		ProviderService? service;

		service = new ProviderService();

		Assert.IsNotNull(service, "ProviderService should not be null after construction.");
		Assert.IsInstanceOfType<DateTimeProvider>(service.DateTime, "DateTime provider should be of type DateTimeProvider.");
		Assert.IsInstanceOfType<DirectoryProvider>(service.Directory, "Directory provider should be of type DirectoryProvider.");
		Assert.IsInstanceOfType<EnvironmentProvider>(service.Environment, "Environment provider should be of type EnvironmentProvider.");
		Assert.IsInstanceOfType<FileProvider>(service.File, "File provider should be of type FileProvider.");
		Assert.IsInstanceOfType<PathProvider>(service.Path, "Path provider should be of type PathProvider.");
	}
}
