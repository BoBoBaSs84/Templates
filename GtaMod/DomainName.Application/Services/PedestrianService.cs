using System.Collections;

using DomainName.Application.Abstractions.Application.Services;
using DomainName.Domain.Events.Peds;
using DomainName.Domain.Events.System;

using GTA;

namespace DomainName.Application.Services;

/// <summary>
/// Represents a collection service of pedestrian (<see cref="Ped"/>) entities.
/// </summary>
internal sealed class PedestrianService : IPedestrianService
{
	private readonly List<Ped> _peds = [];
	private readonly IEventService _eventService;

	/// <summary>
	/// Initializes a instance of the <see cref="PedestrianService"/>.
	/// </summary>
	/// <param name="eventService">The event service instance.</param>
	public PedestrianService(IEventService eventService)
	{
		_eventService = eventService;
		_eventService.Subscribe<TickEvent>(OnTickEvent);
	}

	public int Count => _peds.Count;

	public bool IsReadOnly => false;

	public void Add(Ped item)
	{
		_eventService.Publish(new AddedEvent($"{this}", item.Handle));
		_peds.Add(item);
	}

	public void Clear()
	{
		_peds.ForEach(ped => ped.MarkAsNoLongerNeeded());
		_peds.Clear();
	}

	public bool Contains(Ped item)
		=> _peds.Contains(item);

	public void CopyTo(Ped[] array, int arrayIndex)
		=> _peds.CopyTo(array, arrayIndex);

	public IEnumerator<Ped> GetEnumerator()
		=> _peds.GetEnumerator();

	public bool Remove(Ped item)
	{
		if (_peds.Contains(item))
			item.MarkAsNoLongerNeeded();
		return _peds.Remove(item);
	}

	IEnumerator IEnumerable.GetEnumerator()
		=> _peds.GetEnumerator();

	private void OnTickEvent(TickEvent args)
	{
		foreach (Ped ped in _peds)
		{
			if (ped.IsDead is true)
			{
				_eventService.Publish(new DiedEvent($"{this}", ped.Handle));
				_peds.Remove(ped);
			}
		}
	}
}
