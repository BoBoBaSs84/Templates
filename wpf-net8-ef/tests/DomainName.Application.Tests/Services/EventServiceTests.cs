using DomainName.Application.Services;
using DomainName.Domain.Events.Base;

namespace DomainName.Application.Tests.Services;

[TestClass]
public sealed class EventServiceTests : ApplicationTestBase
{
	private readonly EventService _sut;

	public EventServiceTests()
		=> _sut = new EventService();

	[TestMethod]
	public void SubscribeAndPublishShouldInvokeHandler()
	{
		bool handlerInvoked = false;
		string? receivedMessage = null;
		TestEvent testEvent = new("Hello, World!");

		_sut.Subscribe<TestEvent>(e =>
		{
			handlerInvoked = true;
			receivedMessage = e.Message;
		});

		_sut.Publish(testEvent);

		Assert.IsTrue(handlerInvoked, "Event handler was not invoked.");
		Assert.AreEqual(testEvent.Message, receivedMessage, "Received message does not match the published message.");
	}

	private sealed class TestEvent(string message) : EventBase
	{
		public string Message { get; } = message;
	}
}
