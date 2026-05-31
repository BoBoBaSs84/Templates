using DomainName.Application.Abstractions.Application.Services;
using DomainName.Application.Settings;
using DomainName.Domain.Events.System;
using DomainName.Presentation.Menus.Base;
using DomainName.Presentation.Properties;

namespace DomainName.Presentation.Menus;

/// <summary>
/// Represents the main menu for the modification, providing access to various settings and options related to the mod.
/// </summary>
public sealed class ModificationMainMenu : BaseMenu
{
	private readonly IEventService _eventService;
	private readonly ModificationSettings _settings;

	/// <summary>
	/// Initializes a new instance of the <see cref="ModificationMainMenu"/> class.
	/// </summary>
	/// <param name="eventService">The event service instance.</param>
	/// <param name="settings">The modification settings instance.</param>
	public ModificationMainMenu(IEventService eventService, ModificationSettings settings)
		: base(Resources.ModMenu_Title, Resources.ModMenu_SubTitle, Resources.ModMenu_Description)
	{
		_eventService = eventService;
		_settings = settings;

		RegisterEvents();
		RegisterMenuItems(_settings);
	}

	private void RegisterMenuItems(ModificationSettings settings)
	{
		GeneralSettingsMenu generalSettingsMenu = new(settings.General);
		AddMenu(generalSettingsMenu);
	}

	private void RegisterEvents()
	{
		_eventService.Subscribe<AbortTriggered>(OnAbortTriggered);
		_eventService.Subscribe<KeyReleased>(OnKeyReleased);
		_eventService.Subscribe<TickTriggered>(OnTickTriggered);
	}

	private void OnAbortTriggered(AbortTriggered triggered)
		=> Items.Clear();

	private void OnKeyReleased(KeyReleased @event)
	{
		if (@event.Keys == Keys.F10)
			Visible = !Visible;
	}

	private void OnTickTriggered(TickTriggered @event)
		=> MenuPool.Process();
}
