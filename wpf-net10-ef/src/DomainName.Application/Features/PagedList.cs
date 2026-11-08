using System.Collections;

namespace DomainName.Application.Features;

/// <summary>
/// Represents a paged list of items with metadata information.
/// </summary>
/// <inheritdoc/>
public sealed class PagedList<T> : IPagedList<T>
{
	private readonly List<T> _items;

	/// <summary>
	/// Initializes a new instance of the <see cref="PagedList{T}"/> class with the
	/// specified items, total count, page number, and page size.
	/// </summary>
	/// <param name="items">The items of the current page.</param>
	/// <param name="totalCount">The count of all items, not only the current page.</param>
	/// <param name="pageNumber">The page number.</param>
	/// <param name="pageSize">The page size.</param>
	public PagedList(IEnumerable<T> items, int totalCount, int pageNumber, int pageSize)
	{
		ArgumentNullException.ThrowIfNull(items);

		_items = [.. items];

		int totalPages = pageSize > 0
			? (int)Math.Ceiling(totalCount / (double)pageSize)
			: 0;

		MetaData = new MetaData(pageNumber, totalPages, pageSize, totalCount);
	}

	/// <inheritdoc/>
	public MetaData MetaData { get; }

	/// <inheritdoc/>
	public T this[int index]
		=> _items[index];

	/// <inheritdoc/>
	public int Count
		=> _items.Count;

	/// <inheritdoc/>
	public IEnumerator<T> GetEnumerator()
		=> _items.GetEnumerator();

	/// <inheritdoc/>
	IEnumerator IEnumerable.GetEnumerator()
		=> GetEnumerator();
}
