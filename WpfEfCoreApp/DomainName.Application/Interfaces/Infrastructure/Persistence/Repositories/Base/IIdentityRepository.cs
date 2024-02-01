using DomainName.Domain.Models.Base;

namespace DomainName.Application.Interfaces.Infrastructure.Persistence.Repositories.Base;

/// <summary>
/// The identity repository interface.
/// </summary>
/// <typeparam name="T">The type work with.</typeparam>
public interface IIdentityRepository<T> : IGenericRepository<T> where T : DataModelBase
{
	/// <summary>
	/// Returns an entity of type <typeparamref name="T"/> by its primary key.
	/// </summary>
	/// <param name="id">The primary key of the entity.</param>
	/// <param name="ignoreQueryFilters">Should model-level entity query filters be applied?</param>
	/// <param name="trackChanges">Should the fetched entity be tracked?</param>
	/// <returns>An entity of type <typeparamref name="T"/> or <see langword="null"/>.</returns>
	T? GetById(
		Guid id,
		bool ignoreQueryFilters = false,
		bool trackChanges = false
		);

	/// <summary>
	/// Returns an entity of type <typeparamref name="T"/> by its primary key.
	/// </summary>
	/// <param name="id">The primary key of the entity.</param>
	/// <param name="ignoreQueryFilters">Should model-level entity query filters be applied?</param>
	/// <param name="trackChanges">Should the fetched entity be tracked?</param>
	/// <param name="cancellationToken">The cancellation token to cancel the request.</param>
	/// <returns>An entity of type <typeparamref name="T"/> or <see langword="null"/>.</returns>
	Task<T?> GetByIdAsync(
		Guid id,
		bool ignoreQueryFilters = false,
		bool trackChanges = false,
		CancellationToken cancellationToken = default
		);

	/// <summary>
	/// Returns a collection of entites of type <typeparamref name="T"/> by their primary keys.
	/// </summary>
	/// <param name="ids">The primary keys of the entities.</param>
	/// <param name="ignoreQueryFilters">Should model-level entity query filters be applied?</param>
	/// <param name="trackChanges">Should the fetched entities be tracked?</param>
	/// <returns>A collection of entites of type <typeparamref name="T"/>.</returns>
	IEnumerable<T> GetByIds(
		IEnumerable<Guid> ids,
		bool ignoreQueryFilters = false,
		bool trackChanges = false
		);

	/// <summary>
	/// Returns a collection of entites of type <typeparamref name="T"/> by their primary keys.
	/// </summary>
	/// <param name="ids">The primary keys of the entities.</param>
	/// <param name="ignoreQueryFilters">Should model-level entity query filters be applied?</param>
	/// <param name="trackChanges">Should the fetched entities be tracked?</param>
	/// <param name="cancellationToken">The cancellation token.</param>
	/// <returns>A collection of entities.</returns>
	Task<IEnumerable<T>> GetByIdsAsync(
		IEnumerable<Guid> ids,
		bool ignoreQueryFilters = false,
		bool trackChanges = false,
		CancellationToken cancellationToken = default
		);
}
