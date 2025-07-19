using System.ComponentModel.DataAnnotations;
using System.Drawing;

using DomainName.Domain.Entities.Base;

namespace DomainName.Domain.Entities;

/// <summary>
/// The <see cref="TodoList"/> entity represents a collection of tasks or items to be completed.
/// </summary>
public sealed class TodoList : EntityBase
{
	/// <summary>
	/// Gets or sets the title of the todo list.
	/// </summary>
	[Required, MaxLength(128)]
	public required string Title { get; set; }

	/// <summary>
	/// Gets or sets the description of the todo list, if any.
	/// </summary>
	[MaxLength(2048)]
	public string? Description { get; set; }

	/// <summary>
	/// Gets or sets the color associated with the todo list, if any.
	/// </summary>
	public Color? Color { get; set; }

	/// <summary>
	/// Gets or sets the collection of items in the todo list.
	/// </summary>
	public ICollection<TodoItem> Items { get; } = [];
}
