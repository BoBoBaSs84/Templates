using System.Drawing;

using DomainName.Domain.Entities.Base;

namespace DomainName.Domain.Entities;

/// <summary>
/// Represents a todo item in the application.
/// </summary>
public sealed class TodoEntity : EntityBase
{
	/// <summary>
	/// Gets or sets the title of the todo item.
	/// </summary>
	public required string Title { get; set; }

	/// <summary>
	/// Gets or sets the description of the todo item.
	/// </summary>
	public string? Description { get; set; }

	/// <summary>
	/// Gets or sets the color associated with the todo item.
	/// </summary>
	public required Color Color { get; set; }

	/// <summary>
	/// Gets or sets a value indicating whether the todo item is completed.
	/// </summary>
	public bool IsDone { get; set; }
}
