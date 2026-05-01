using DomainName.Application.Events;

namespace DomainName.Application.Tests.Events;

[TestClass]
public sealed class SettingsLoadedEventTests
{
	[TestMethod]
	public void ConstructorShouldInitializePropertiesCorrectly()
	{
		SettingsLoadedEvent @event = new();

		Assert.AreNotEqual(Guid.Empty, @event.Id);
	}
}
