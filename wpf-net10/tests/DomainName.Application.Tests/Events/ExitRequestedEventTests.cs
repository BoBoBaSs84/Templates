using DomainName.Application.Events;

namespace DomainName.Application.Tests.Events;

[TestClass]
public sealed class ExitRequestedEventTests
{
	[TestMethod]
	public void ConstructorShouldInitializePropertiesCorrectly()
	{
		ExitRequestedEvent @event = new();

		Assert.AreNotEqual(Guid.Empty, @event.Id);
	}
}
