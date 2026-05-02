using DomainName.Application.Events;

namespace DomainName.Application.Tests.Events;

[TestClass]
public sealed class DelayedStatusChangedEventTests
{
	[TestMethod]
	public void ConstructorShouldInitializePropertiesWithDefaultDuration()
	{
		string text = "Delayed status";

		DelayedStatusChangedEvent @event = new(text);

		Assert.AreNotEqual(Guid.Empty, @event.Id);
		Assert.AreEqual(text, @event.Text);
		Assert.IsTrue(@event.AutoClear);
		Assert.AreEqual(2000, @event.Duration);
	}

	[TestMethod]
	public void ConstructorShouldInitializePropertiesWithSpecifiedDuration()
	{
		string text = "Delayed status";
		int duration = 4500;

		DelayedStatusChangedEvent @event = new(text, duration);

		Assert.AreNotEqual(Guid.Empty, @event.Id);
		Assert.AreEqual(text, @event.Text);
		Assert.IsTrue(@event.AutoClear);
		Assert.AreEqual(duration, @event.Duration);
	}
}
