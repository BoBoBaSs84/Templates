namespace DomainName.Domain.Enumerators;

/// <summary>
/// The <see cref="TodoPriority"/> enumeration represents the priority levels for todo items.
/// </summary>
public enum TodoPriority : byte
{
	/// <summary>
	/// Represents no priority assigned to the todo item.
	/// </summary>
	None = 0,
	/// <summary>
	/// Represents a low priority item.
	/// </summary>
	Low = 1,
	/// <summary>
	/// Represents a medium priority item.
	/// </summary>
	Medium = 2,
	/// <summary>
	/// Represents a high priority item.
	/// </summary>
	High = 3
}
