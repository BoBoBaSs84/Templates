using System.Configuration;

using DomainName.Application.Abstractions.Application.Services;
using DomainName.Application.Events;

namespace DomainName.Application.Services;

/// <summary>
/// Represents a service that manages the application's language settings and raises events
/// when the language is changed.
/// </summary>
internal sealed class LanguageService : ILanguageService
{
	private const string AppSettingsSection = "AppSettings";
	private const string LanguageSettingKey = "Language";
	private readonly Configuration _configuration;
	private readonly IEventService _eventService;

	/// <summary>
	/// Initializes a new instance of the <see cref="LanguageService"/> class.
	/// </summary>
	/// <param name="eventService">The event service instance to use for publishing and subscribing events.</param>
	public LanguageService(IEventService eventService)
	{
		_eventService = eventService;
		_configuration = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
		_eventService.Subscribe<ChangeLanguageEvent>(OnChangeLanguage);
	}

	public string GetLanguage()
		=> _configuration.AppSettings.Settings[LanguageSettingKey].Value;

	public void SetLanguage(string language)
	{
		_configuration.AppSettings.Settings[LanguageSettingKey].Value = language;
		_configuration.Save(ConfigurationSaveMode.Modified);
		ConfigurationManager.RefreshSection(AppSettingsSection);
		_eventService.Publish(new LanguageChangedEvent(language));
	}

	private void OnChangeLanguage(ChangeLanguageEvent @event)
	{
		if (@event.Language != GetLanguage())
			SetLanguage(@event.Language);
	}
}
