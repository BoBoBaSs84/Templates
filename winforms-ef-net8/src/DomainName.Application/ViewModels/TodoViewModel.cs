using System.ComponentModel;

using BB84.Extensions;
using BB84.Notifications.Attributes;

using DomainName.Application.Abstractions.Infrastructure.Persistence;
using DomainName.Application.Abstractions.Presentation.Services;
using DomainName.Application.ViewModels.Base;
using DomainName.Domain.Entities;
using DomainName.Domain.Enumerators;

using Microsoft.EntityFrameworkCore;

namespace DomainName.Application.ViewModels;

/// <summary>
/// Represents the view model for managing todo items in the application.
/// </summary>
/// <param name="databaseContext">The database context instance to use for data operations.</param>
/// <param name="notificationService">The notification service instance to use for displaying messages.</param>
public sealed class TodoViewModel(IDatabaseContext databaseContext, INotificationService notificationService) : ViewModelBase
{
	private TodoList? _selectedList;
	private TodoItem? _selectedItem;

	/// <summary>
	/// Represents the collection of todo lists in the application.
	/// </summary>
	public BindingList<TodoList> Lists { get; private set; } = [];

	/// <summary>
	/// Represents the collection of todo items in the application.
	/// </summary>
	[NotifyChanged(nameof(IsListSelected))]
	public TodoList? SelectedList
	{
		get => _selectedList;
		set => SetProperty(ref _selectedList, value);
	}

	/// <summary>
	/// Idicates whether a todo list is currently selected.
	/// </summary>
	public bool IsListSelected => SelectedList is not null;

	/// <summary>
	/// Represents the collection of todo items in the selected todo list.
	/// </summary>
	public BindingList<TodoItem> Items { get; private set; } = [];

	/// <summary>
	/// Represents the collection of todo item priorities available in the application.
	/// </summary>
	public IEnumerable<TodoPriority> Priorities { get; } = TodoPriority.None.GetValues();

	/// <summary>
	/// Represents the currently selected todo item in the selected todo list.
	/// </summary>
	[NotifyChanged(nameof(IsItemSelected))]
	public TodoItem? SelectedItem
	{
		get => _selectedItem;
		set => SetProperty(ref _selectedItem, value);
	}

	/// <summary>
	/// Inicates whether a todo item is currently selected in the selected todo list.
	/// </summary>
	public bool IsItemSelected => SelectedItem is not null;

	/// <summary>
	/// Retrieves the todo lists from the database and populates the Lists collection.
	/// </summary>
	public void LoadLists()
	{
		try
		{
			databaseContext.TodoLists.Load();
			Lists = databaseContext.TodoLists.Local.ToBindingList();
		}
		catch (Exception ex)
		{
			notificationService.ShowError($"Failed to load todo lists: {ex.Message}");
		}
	}

	/// <summary>
	/// Retrieves the todo items for the selected todo list from the database and populates the Items collection.
	/// </summary>
	public void LoadItems()
	{
		if (SelectedList is null)
			return;

		try
		{
			databaseContext.TodoItems
				.Where(item => item.ListId == SelectedList.Id)
				.Load();
			
			Items = databaseContext.TodoItems.Local
				.ToBindingList();
			
			SelectedItem = Items.FirstOrDefault();
		}
		catch (Exception ex)
		{
			notificationService.ShowError($"Failed to load todo items: {ex.Message}");
		}
	}

	/// <summary>
	/// Saves any changes made to the todo lists or items in the database.
	/// </summary>
	public void SaveChanges()
	{
		bool hasChanges = databaseContext.ChangeTracker.HasChanges();

		if (!hasChanges)
			return;

		DialogResult answer = notificationService.ShowQuestion("You have unsaved changes. Do you want to save them?");

		if (answer != DialogResult.Yes)
			return;

		try
		{
			databaseContext.SaveChanges();
			notificationService.ShowInformation("Changes saved successfully.");
		}
		catch (Exception ex)
		{
			notificationService.ShowError($"Failed to save changes: {ex.Message}");
		}
	}
}
