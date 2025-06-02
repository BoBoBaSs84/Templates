using DomainName.Application.Interfaces.Application.Features;

namespace DomainName.Application.Features.Pagination;

/// <summary>
/// The paged list class.
/// </summary>
/// <typeparam name="T">The type to work with.</typeparam>
public sealed class PagedList<T> : List<T>, IPagedList<T> where T : class
{
	/// <summary>
	/// Initilizes an instance of the <see cref="PagedList{T}"/> class.
	/// </summary>
	/// <param name="items">The items to add to the paged list.</param>
	/// <param name="totalCount">The total count of items.</param>
	/// <param name="pageNumber">The page number.</param>
	/// <param name="pageSize">The page size.</param>
	public PagedList(IEnumerable<T> items, int totalCount, int pageNumber, int pageSize)
	{
		int totalPages = (int)Math.Ceiling(totalCount / (double)pageSize);
		MetaData = new(pageNumber, totalPages, pageSize, totalCount);
		AddRange(items);
	}

	/// <inheritdoc/>
	public MetaData MetaData { get; }
}
