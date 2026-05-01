using DomainName.Application.Events;

namespace DomainName.Application.Tests.Events;

[TestClass]
public sealed class LanguageChangedEventTests
{
	[TestMethod]
	public void ConstructorShouldInitializePropertiesCorrectly()
	{
		string language = "German";

		LanguageChangedEvent @event = new(language);

		Assert.AreNotEqual(Guid.Empty, @event.Id);
		Assert.AreEqual(language, @event.Language);
	}
}
