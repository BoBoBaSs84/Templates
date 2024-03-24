using DomainName.Domain.Interfaces.Models.Base;

namespace DomainName.Application.Interfaces.Infrastructure.Persistence.Repositories.Base;

/// <summary>
/// The enumerator repository interface.
/// </summary>
/// <typeparam name="T">The enumerator type work with.</typeparam>
public interface IEnumeratorRepository<T> : IGenericRepository<T> where T : class, IEnumeratorModelBase
{
	/// <summary>
	/// Returns an enumerator entity by its primary key.
	/// </summary>
	/// <param name="id">The primary key of the enumerator entity.</param>
	/// <param name="ignoreQueryFilters">Should model-level entity query filters be applied?</param>
	/// <param name="trackChanges">Should the fetched entity be tracked?</param>
	/// <returns>The enumerator entity or <see langword="null"/>.</returns>
	T? GetById(
		int id,
		bool ignoreQueryFilters = false,
		bool trackChanges = false
		);

	/// <summary>
	/// Returns an enumerator entity by its primary key.
	/// </summary>
	/// <param name="id">The primary key of the enumerator entity.</param>
	/// <param name="ignoreQueryFilters">Should model-level entity query filters be applied?</param>
	/// <param name="trackChanges">Should the fetched entity be tracked?</param>
	/// <param name="cancellationToken">The cancellation token to cancel the request.</param>
	/// <returns>The enumerator entity or <see langword="null"/>.</returns>
	Task<T?> GetByIdAsync(
		int id,
		bool ignoreQueryFilters = false,
		bool trackChanges = false,
		CancellationToken cancellationToken = default
		);

	/// <summary>
	/// Returns a collection of enumerator entites by their primary keys.
	/// </summary>
	/// <param name="ids">The primary keys of the enumerator entities.</param>
	/// <param name="ignoreQueryFilters">Should model-level entity query filters be applied?</param>
	/// <param name="trackChanges">Should the fetched entities be tracked?</param>
	/// <returns>A collection of enumerator entites.</returns>
	IEnumerable<T> GetByIds(
		IEnumerable<int> ids,
		bool ignoreQueryFilters = false,
		bool trackChanges = false
		);

	/// <summary>
	/// Returns a collection of enumerator entites by their primary keys.
	/// </summary>
	/// <param name="ids">The primary keys of the enumerator entities.</param>
	/// <param name="ignoreQueryFilters">Should model-level entity query filters be applied?</param>
	/// <param name="trackChanges">Should the fetched entities be tracked?</param>
	/// <param name="cancellationToken">The cancellation token.</param>
	/// <returns>A collection of enumerator entites.</returns>
	Task<IEnumerable<T>> GetByIdsAsync(
		IEnumerable<int> ids,
		bool ignoreQueryFilters = false,
		bool trackChanges = false,
		CancellationToken cancellationToken = default
		);

	/// <summary>
	/// Returns an enumerator entity by its name.
	/// </summary>
	/// <param name="name">The name of the enumerator entity.</param>
	/// <param name="ignoreQueryFilters">Should model-level entity query filters be applied?</param>
	/// <param name="trackChanges">Should the fetched entity be tracked?</param>
	/// <returns>The enumerator entity or <see langword="null"/>.</returns>
	T? GetByName(
		string name,
		bool ignoreQueryFilters = false,
		bool trackChanges = false
		);

	/// <summary>
	/// Returns an enumerator entity by its name.
	/// </summary>
	/// <param name="name">The name of the enumerator entity.</param>
	/// <param name="ignoreQueryFilters">Should model-level entity query filters be applied?</param>
	/// <param name="trackChanges">Should the fetched entity be tracked?</param>
	/// <param name="cancellationToken">The cancellation token to cancel the request.</param>
	/// <returns>The enumerator entity or <see langword="null"/>.</returns>
	Task<T?> GetByName(
		string name,
		bool ignoreQueryFilters = false,
		bool trackChanges = false,
		CancellationToken cancellationToken = default
		);
}
