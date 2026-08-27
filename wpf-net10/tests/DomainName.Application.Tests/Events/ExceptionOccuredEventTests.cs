using DomainName.Application.Events;

namespace DomainName.Application.Tests.Events;

[TestClass]
public sealed class ExceptionOccuredEventTests
{
	[TestMethod]
	public void ConstructorShouldInitializePropertiesCorrectly()
	{
		string errorMessage = "An error occurred.";
		InvalidOperationException exception = new("Invalid operation.");

		ExceptionOccuredEvent @event = new(errorMessage, exception);

		Assert.AreNotEqual(Guid.Empty, @event.Id);
		Assert.AreEqual(errorMessage, @event.Message);
		Assert.AreEqual(exception, @event.Exception);
	}
}
