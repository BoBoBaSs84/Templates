namespace DomainName.Application.Features;

/// <summary>
/// Represents a paged read-only list of items with associated metadata.
/// </summary>
/// <inheritdoc/>
public interface IPagedList<T> : IReadOnlyList<T>
{
	/// <summary>
	/// Gets the metadata associated with the paged list, such as total item
	/// count, page size, and current page index.
	/// </summary>
	MetaData MetaData { get; }
}
