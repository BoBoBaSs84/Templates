using System.Drawing;

using DomainName.Domain.Entities.Base;

namespace DomainName.Domain.Entities;

public sealed class TodoEntity : EntityBase
{
	public string Title { get; set; }
	public string? Description { get; set; }
	public Color Color { get; set; }
	public bool IsDone { get; set; }
}
