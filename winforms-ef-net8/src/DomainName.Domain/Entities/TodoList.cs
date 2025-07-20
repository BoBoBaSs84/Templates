using System.ComponentModel.DataAnnotations;
using System.Drawing;

using DomainName.Domain.Entities.Base;

using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace DomainName.Domain.Entities;

/// <summary>
/// The <see cref="TodoList"/> entity represents a collection of tasks or items to be completed.
/// </summary>
public sealed class TodoList : EntityBase
{
	private string _title = string.Empty;
	private string? _description;
	private Color? _color;

	/// <summary>
	/// Gets or sets the title of the todo list.
	/// </summary>
	[Required, MaxLength(128)]
	public string Title
	{
		get => _title;
		set => SetProperty(ref _title, value);
	}

	/// <summary>
	/// Gets or sets the description of the todo list, if any.
	/// </summary>
	[MaxLength(2048)]
	public string? Description
	{
		get => _description;
		set => SetProperty(ref _description, value);
	}

	/// <summary>
	/// Gets or sets the color associated with the todo list, if any.
	/// </summary>
	public Color? Color
	{
		get => _color;
		set => SetProperty(ref _color, value);
	}

	/// <summary>
	/// Gets or sets the collection of items in the todo list.
	/// </summary>
	public ObservableCollectionListSource<TodoItem> Items { get; } = [];
}
