using DomainName.Application.Events;

namespace DomainName.Application.Tests.Events;

[TestClass]
public sealed class StatusChangedEventTests
{
	[TestMethod]
	public void ConstructorShouldInitializePropertiesCorrectly()
	{
		string text = "Status updated";
		bool autoClear = true;
		int duration = 5000;

		StatusChangedEvent @event = new(text, autoClear, duration);

		Assert.AreNotEqual(Guid.Empty, @event.Id);
		Assert.AreEqual(text, @event.Text);
		Assert.AreEqual(autoClear, @event.AutoClear);
		Assert.AreEqual(duration, @event.Duration);
	}
}
