using DomainName.Application.Interfaces.Infrastructure.Services;
using DomainName.Application.Interfaces.Presentation.Services;
using DomainName.Application.Services;

using Microsoft.Extensions.Logging;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using Moq;

namespace DomainName.Application.Tests.Services;

[TestClass]
public sealed class WebServiceTests
{
	[TestMethod]
	public async Task GetPizzaContentAsync_ShouldReturnNull_WhenExceptionIsThrown()
	{
		Mock<IHttpClientFactory> httpClientFactoryMock = new();
		Mock<ILoggerService<WebService>> loggerServiceMock = new();
		Mock<INotificationService> notificationServiceMock = new();
		httpClientFactoryMock.Setup(x => x.CreateClient(It.IsAny<string>()))
			.Throws<Exception>();
		WebService sut = new(httpClientFactoryMock.Object, loggerServiceMock.Object, notificationServiceMock.Object);

		string? result = await sut.GetPizzaContentAsync()
			.ConfigureAwait(false);

		Assert.IsNotNull(result);
		loggerServiceMock.Verify(x => x.Log(It.IsAny<Action<ILogger, Exception?>>(), It.IsAny<Exception?>()), Times.Once);
		notificationServiceMock.Verify(x => x.SendError(It.IsAny<string>()), Times.Once);
	}
}
