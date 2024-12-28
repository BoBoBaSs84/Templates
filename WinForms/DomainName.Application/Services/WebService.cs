﻿using DomainName.Application.Interfaces.Application.Services;
using DomainName.Application.Interfaces.Infrastructure.Services;
using DomainName.Application.Interfaces.Presentation.Services;

using Microsoft.Extensions.Logging;

using ApplicationConstants = DomainName.Application.Common.Constants;

namespace DomainName.Application.Services;

/// <summary>
/// The web service class.
/// </summary>
/// <param name="httpClientFactory">The http client factory instance to use.</param>
/// <param name="loggerService">The logger service instance to use.</param>
/// <param name="notificationService">The notification service instance to use.</param>
internal sealed class WebService(IHttpClientFactory httpClientFactory, ILoggerService<WebService> loggerService, INotificationService notificationService) : IWebService
{
	private static readonly Action<ILogger, Exception?> LogException =
		LoggerMessage.Define(LogLevel.Error, 0, "Exception occured.");

	public async Task<string> GetPizzaContentAsync(CancellationToken cancellationToken = default)
	{
		try
		{
			HttpClient httpClient = httpClientFactory.CreateClient(ApplicationConstants.HttpClient.WikipediaClient);
			string requestUri = @"/w/api.php?action=query&prop=revisions&format=json&rvprop=content&rvsection=0&titles=pizza";
			using HttpResponseMessage responseMessage = await httpClient.GetAsync(requestUri, cancellationToken)
				.ConfigureAwait(false);

			_ = responseMessage.EnsureSuccessStatusCode();

			string jsonContent = await responseMessage.Content.ReadAsStringAsync(cancellationToken)
				.ConfigureAwait(false);

			return jsonContent;
		}
		catch (Exception ex)
		{
			loggerService.Log(LogException, ex);
			notificationService.SendError(ex.Message);
			return string.Empty;
		}
	}
}