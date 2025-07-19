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
	/// <summary>
	/// Gets or sets the unique identifier of the todo list that this item belongs to.
	/// </summary>
	public Guid ListId { get; set; }

	/// <summary>
	/// Gets or sets the title of the todo item.
	/// </summary>
	[Required, MaxLength(128)]
	public required string Title { get; set; }

	/// <summary>
	/// Gets or sets the description of the todo item, if any.
	/// </summary>
	[MaxLength(2048)]
	public string? Description { get; set; }

	/// <summary>
	/// Gets or sets the priority of the todo item.
	/// </summary>
	public TodoPriority Priority { get; set; }

	/// <summary>
	/// Gets or sets a value indicating whether the todo item is completed.
	/// </summary>
	public bool IsCompleted { get; set; }

	/// <summary>
	/// Gets or sets the color associated with the todo item, if any.
	/// </summary>
	public Color? Color { get; set; }

	/// <summary>
	/// The navigation property to the todo list that this item belongs to.
	/// </summary>
	public required TodoList List { get; set; }
}
