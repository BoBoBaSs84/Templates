using DomainName.Application.Events;

namespace DomainName.Application.Tests.Events;

[TestClass]
public sealed class ProgressChangedEventTests
{
	[TestMethod]
	public void ConstructorWithSingleValueShouldInitializePropertiesCorrectly()
	{
		int value = 42;

		ProgressChangedEvent @event = new(value);

		Assert.AreNotEqual(Guid.Empty, @event.Id);
		Assert.AreEqual(value, @event.Value);
		Assert.AreEqual(0, @event.Minimum);
		Assert.AreEqual(100, @event.Maximum);
	}

	[TestMethod]
	public void ConstructorWithMinAndMaxShouldInitializePropertiesCorrectly()
	{
		int value = 50;
		int minimum = 10;
		int maximum = 90;

		ProgressChangedEvent @event = new(value, minimum, maximum);

		Assert.AreNotEqual(Guid.Empty, @event.Id);
		Assert.AreEqual(value, @event.Value);
		Assert.AreEqual(minimum, @event.Minimum);
		Assert.AreEqual(maximum, @event.Maximum);
	}
}
