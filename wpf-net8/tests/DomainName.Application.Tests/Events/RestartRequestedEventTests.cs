using DomainName.Application.Events;

namespace DomainName.Application.Tests.Events;

[TestClass]
public sealed class RestartRequestedEventTests
{
	[TestMethod]
	public void ConstructorShouldInitializePropertiesCorrectly()
	{
		RestartRequestedEvent @event = new();

		Assert.AreNotEqual(Guid.Empty, @event.Id);
	}
}
