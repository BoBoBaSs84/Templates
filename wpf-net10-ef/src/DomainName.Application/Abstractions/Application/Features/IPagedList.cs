using DomainName.Application.Features.Pagination;

namespace DomainName.Application.Abstractions.Application.Features;

/// <summary>
/// The paged list interface.
/// </summary>
/// <typeparam name="T">The type to work with.</typeparam>
public interface IPagedList<T> : IList<T> where T : class
{
	/// <summary>
	/// The meta data for the paged list.
	/// </summary>
	public MetaData MetaData { get; }
}
