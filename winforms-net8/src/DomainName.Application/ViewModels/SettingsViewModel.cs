using DomainName.Application.Abstractions.Application.Services;
using DomainName.Application.ViewModels.Base;
using DomainName.Domain.Enumerators;

namespace DomainName.Application.ViewModels;

public sealed class SettingsViewModel : ViewModelBase
{
	private readonly ILanguageService _languageService;
	private Language _language = Language.English;
	private LogLevel _logLevel = LogLevel.Error;

	public SettingsViewModel(ILanguageService languageService)
	{
		_languageService = languageService;
	}

	public Language Language
	{
		get => _language;
		set => SetProperty(ref _language, value);
	}

	public LogLevel LogLevel
	{
		get => _logLevel;
		set => SetProperty(ref _logLevel, value);
	}
}
