using DomainName.Application.Abstractions.Application.Services;
using DomainName.Domain.Events.System;
using DomainName.Presentation.Menus.Base;

namespace DomainName.Presentation.Menus;

/// <summary>
/// The mod menu class.
/// </summary>
public sealed class ModMenu : BaseMenu
{
	private readonly IEventService _eventService;

	/// <summary>
	/// Initializes a new instance of the <see cref="ModMenu"/> class.
	/// </summary>
	/// <param name="eventService">The event service instance.</param>
	public ModMenu(IEventService eventService) : base("Main", "Mod Menu", "The fancy mod menu.")
	{
		_eventService = eventService;
		_eventService.Subscribe<KeyUpEvent>(OnKeyUpEvent);
		_eventService.Subscribe<TickEvent>(OnTickEvent);
	}

	private void OnKeyUpEvent(KeyUpEvent @event)
	{
		if (@event.KeyData == Keys.F10)
			Visible = !Visible;
	}

	private void OnTickEvent(TickEvent @event)
		=> MenuPool.Process();
}
