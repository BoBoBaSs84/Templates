using System.ComponentModel;

using DomainName.Application.Abstractions.Infrastructure.Persistence;
using DomainName.Application.Abstractions.Presentation.Services;
using DomainName.Application.ViewModels.Base;
using DomainName.Domain.Entities;

namespace DomainName.Application.ViewModels;

/// <summary>
/// Represents the view model for managing todo items in the application.
/// </summary>
/// <param name="databaseContext">The database context instance to use for data operations.</param>
/// <param name="notificationService">The notification service instance to use for displaying messages.</param>
public sealed class TodoViewModel(IDatabaseContext databaseContext, INotificationService notificationService) : ViewModelBase
{
	/// <summary>
	/// Represents the collection of todo lists in the application.
	/// </summary>
	public BindingList<TodoList> Lists { get; private set; } = [];

	/// <summary>
	/// Represents the collection of todo items in the application.
	/// </summary>
	public TodoList? SelectedList { get; set; }

	/// <summary>
	/// Represents the collection of todo items in the selected todo list.
	/// </summary>
	public BindingList<TodoItem> Items { get; private set; } = [];

	/// <summary>
	/// Retrieves the todo lists from the database and populates the Lists collection.
	/// </summary>
	public void LoadLists()
	{
		try
		{
			Lists.Clear();
			var todoLists = databaseContext.TodoLists.ToList();
			foreach (var list in todoLists)
				Lists.Add(list);
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
			Items.Clear();
			List<TodoItem> todoItems = [.. databaseContext.TodoItems.Where(item => item.ListId == SelectedList.Id)];
			foreach (TodoItem item in todoItems)
				Items.Add(item);
		}
		catch (Exception ex)
		{
			notificationService.ShowError($"Failed to load todo items: {ex.Message}");
		}
	}
}
