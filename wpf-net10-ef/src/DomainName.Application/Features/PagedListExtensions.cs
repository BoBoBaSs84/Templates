namespace DomainName.Application.Features;

/// <summary>
/// Provides the helpers that turn a sequence into a <see cref="PagedList{T}"/>.
/// </summary>
public static class PagedListExtensions
{
	/// <summary>
	/// Creates the requested page of <paramref name="source"/>, which is enumerated once.
	/// </summary>
	/// <typeparam name="T">The type of the items.</typeparam>
	/// <param name="source">All items to page through.</param>
	/// <param name="pageNumber">The page number, the first page is page one.</param>
	/// <param name="pageSize">The page size.</param>
	/// <returns>The requested page with the metadata of the whole sequence.</returns>
	public static PagedList<T> ToPagedList<T>(this IEnumerable<T> source, int pageNumber, int pageSize)
	{
		ArgumentNullException.ThrowIfNull(source);

		List<T> items = [.. source];

		return new PagedList<T>(items.Skip((pageNumber - 1) * pageSize).Take(pageSize), items.Count, pageNumber, pageSize);
	}

	/// <summary>
	/// Creates the requested page from the <paramref name="query"/> of a request.
	/// </summary>
	/// <typeparam name="T">The type of the items.</typeparam>
	/// <param name="source">All items to page through.</param>
	/// <param name="query">The request the page number and the page size are taken from.</param>
	/// <returns>The requested page with the metadata of the whole sequence.</returns>
	public static PagedList<T> ToPagedList<T>(this IEnumerable<T> source, PagedQuery query)
	{
		ArgumentNullException.ThrowIfNull(query);

		return source.ToPagedList(query.PageNumber, query.PageSize);
	}
}
