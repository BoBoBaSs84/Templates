using System.ComponentModel.DataAnnotations;
using System.Drawing;

using DomainName.Domain.Entities.Base;
using DomainName.Domain.Enumerators;

namespace DomainName.Domain.Entities;

/// <summary>
/// The <see cref="TodoItem"/> entity represents a single task or item to be completed within a todo list.
/// </summary>
public sealed class TodoItem : EntityBase
{
	private Guid _listId;
	private string _title = string.Empty;
	private string? _description;
	private TodoPriority _priority;
	private bool _isCompleted;
	private Color? _color;
	private TodoList _list = default!;

	/// <summary>
	/// Gets or sets the unique identifier of the todo list that this item belongs to.
	/// </summary>
	public Guid ListId
	{
		get => _listId;
		set => SetProperty(ref _listId, value);
	}

	/// <summary>
	/// Gets or sets the title of the todo item.
	/// </summary>
	[Required, MaxLength(128)]
	public string Title
	{
		get => _title;
		set => SetProperty(ref _title, value);
	}

	/// <summary>
	/// Gets or sets the description of the todo item, if any.
	/// </summary>
	[MaxLength(2048)]
	public string? Description
	{
		get => _description;
		set => SetProperty(ref _description, value);
	}

	/// <summary>
	/// Gets or sets the priority of the todo item.
	/// </summary>
	public TodoPriority Priority
	{
		get => _priority;
		set => SetProperty(ref _priority, value);
	}

	/// <summary>
	/// Gets or sets a value indicating whether the todo item is completed.
	/// </summary>
	public bool IsCompleted
	{
		get => _isCompleted;
		set => SetProperty(ref _isCompleted, value);
	}

	/// <summary>
	/// Gets or sets the color associated with the todo item, if any.
	/// </summary>
	public Color? Color
	{
		get => _color;
		set => SetProperty(ref _color, value);
	}

	/// <summary>
	/// The navigation property to the todo list that this item belongs to.
	/// </summary>
	public required TodoList List
	{
		get => _list;
		set => SetProperty(ref _list, value);
	}
}
