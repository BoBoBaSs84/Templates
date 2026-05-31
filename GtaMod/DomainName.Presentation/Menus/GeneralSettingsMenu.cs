using DomainName.Domain.Abstractions.Settings;
using DomainName.Presentation.Extensions;
using DomainName.Presentation.Menus.Base;
using DomainName.Presentation.Properties;

namespace DomainName.Presentation.Menus;

/// <summary>
/// Represents the general settings menu for the modification, allowing users to configure
/// various general options related to the mod's behavior and functionality.
/// </summary>
internal sealed class GeneralSettingsMenu : BaseMenu
{
	/// <summary>
	/// Initializes a new instance of the <see cref="GeneralSettingsMenu"/> class.
	/// </summary>
	/// <param name="settings">The general settings instance to bind the menu options to.</param>
	public GeneralSettingsMenu(IGeneralSettings settings)
		: base(Resources.GeneralSettingsMenu_Title, Resources.GeneralSettingsMenu_SubTitle, Resources.GeneralSettingsMenu_Description)
	{
		AddCheckbox(Resources.GeneralSettingsMenu_DebugCheckBox_Title, Resources.GeneralSettingsMenu_DebugCheckBox_Description)
			.BindTo(settings, nameof(IGeneralSettings.IsDebugMode));

		AddCheckbox(Resources.GeneralSettingsMenu_LoggingCheckBox_Title, Resources.GeneralSettingsMenu_LoggingCheckBox_Description)
			.BindTo(settings, nameof(IGeneralSettings.IsLoggingEnabled));
	}
}
