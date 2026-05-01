using BB84.Extensions;

using DomainName.Application.Abstractions.Application.Services;
using DomainName.Application.Abstractions.Infrastructure.Services;
using DomainName.Application.Events;
using DomainName.Application.Settings;
using DomainName.Infrastructure.Common;

using Microsoft.Extensions.Logging;

using RESX = DomainName.Infrastructure.Properties.Resources;

namespace DomainName.Infrastructure.Services;

/// <summary>
/// Represents a service for managing application settings, providing methods to retrieve and save settings asynchronously.
/// </summary>
internal sealed class SettingsService : ISettingsService
{
	private readonly IEventService _eventService;
	private readonly ILoggerService<SettingsService> _loggerService;
	private readonly IProviderService _providerService;
	private readonly ApplicationSettings _applicationSettings;
	private readonly string _settingsFileName;
	private readonly string _settingsFilePath;

	private static readonly Action<ILogger, string, Exception?> LogError =
		LoggerMessage.Define<string>(LogLevel.Error, 0, "{Error}");

	/// <summary>
	/// Initializes a new instance of the <see cref="SettingsService"/> class.
	/// </summary>
	/// <param name="eventService">The service responsible for managing application events.</param>
	/// <param name="loggerService">The service responsible for logging application information, warnings, and errors.</param>
	/// <param name="providerService">The service responsible for providing access to various application resources</param>
	/// <param name="applicationSettings">The current application settings.</param>
	public SettingsService(IEventService eventService, ILoggerService<SettingsService> loggerService, IProviderService providerService, ApplicationSettings applicationSettings)
	{
		_eventService = eventService;
		_loggerService = loggerService;
		_providerService = providerService;
		_settingsFileName = $"{AssemblyInformation.Product}.ini";
		_settingsFilePath = _providerService.Environment.CurrentDirectory;
		_applicationSettings = applicationSettings;

		RegisterSettingsChangeHandler();
	}

	public async Task LoadAsync(CancellationToken cancellationToken = default)
	{
		try
		{
			string filePath = Path.Combine(_settingsFilePath, _settingsFileName);

			if (_providerService.File.Exists(filePath).IsFalse())
			{
				ApplicationSettings defaultSettings = new();

				await SaveAsync(defaultSettings, cancellationToken)
					.ConfigureAwait(false);
			}

			string fileContent = await _providerService.File
				.ReadAllTextAsync(filePath, cancellationToken)
				.ConfigureAwait(false);

			ApplicationSettings newSettings = ApplicationSettings
				.Read(fileContent);

			_applicationSettings.Load(newSettings);
			_eventService.Publish(new SettingsLoadedEvent());
			_eventService.Publish(new DelayedStatusChangedEvent(RESX.SettingsService_Load_Success));
		}
		catch (Exception ex)
		{
			string message = RESX.SettingsService_Load_Failed;
			_eventService.Publish(new ExceptionOccuredEvent(message, ex));
			_eventService.Publish(new DelayedStatusChangedEvent(message));
			_loggerService.Log(LogError, message, ex);
		}
	}

	public async Task SaveAsync(ApplicationSettings settings, CancellationToken cancellationToken = default)
	{
		try
		{
			string filePath = _providerService.Path.Combine(_settingsFilePath, _settingsFileName);
			string fileContent = ApplicationSettings.Write(settings);

			await _providerService.File
				.WriteAllTextAsync(filePath, fileContent, cancellationToken)
				.ConfigureAwait(false);

			_eventService.Publish(new SettingsSavedEvent());
			_eventService.Publish(new DelayedStatusChangedEvent(RESX.SettingsService_Save_Success));
		}
		catch (Exception ex)
		{
			string message = RESX.SettingsService_Save_Failed;
			_eventService.Publish(new ExceptionOccuredEvent(message, ex));
			_eventService.Publish(new DelayedStatusChangedEvent(message));
			_loggerService.Log(LogError, message, ex);
		}
	}

	private void RegisterSettingsChangeHandler()
	{
		_applicationSettings.General.PropertyChanged += (sender, args) =>
		{
			SaveAsync(_applicationSettings).GetAwaiter().GetResult();

			if (args.PropertyName is nameof(GeneralSettings.Language))
				_eventService.Publish(new LanguageChangedEvent(args.PropertyName));
		};
	}
}
