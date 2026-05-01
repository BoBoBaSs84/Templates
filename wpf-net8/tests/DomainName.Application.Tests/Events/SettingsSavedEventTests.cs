using DomainName.Application.Events;

namespace DomainName.Application.Tests.Events;

[TestClass]
public sealed class SettingsSavedEventTests
{
	[TestMethod]
	public void ConstructorShouldInitializePropertiesCorrectly()
	{
		SettingsSavedEvent @event = new();

		Assert.AreNotEqual(Guid.Empty, @event.Id);
	}
}
