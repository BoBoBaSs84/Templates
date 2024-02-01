using System.Linq.Expressions;

namespace DomainName.Application.Interfaces.Infrastructure.Persistence.Repositories.Base;

/// <summary>
/// The generic repository interface.
/// </summary>
public interface IGenericRepository<T> where T : class
{
	/// <summary>
	/// Creates an entity of type <typeparamref name="T"/>.
	/// </summary>
	/// <param name="entity">The entity to create.</param>
	void Create(T entity);

	/// <summary>
	/// Creates an entity of type <typeparamref name="T"/>.
	/// </summary>
	/// <param name="entity">The entity to create.</param>
	/// <param name="cancellationToken">The cancellation token to cancel the request.</param>
	/// <returns><see cref="Task"/></returns>
	Task CreateAsync(T entity, CancellationToken cancellationToken = default);

	/// <summary>
	/// Creates multiple entities of type <typeparamref name="T"/>.
	/// </summary>
	/// <param name="entities">The entities to create.</param>
	void Create(IEnumerable<T> entities);

	/// <summary>
	/// Creates multiple entities of type <typeparamref name="T"/>.
	/// </summary>
	/// <param name="entities">The entities to create.</param>
	/// <param name="cancellationToken">The cancellation token to cancel the request.</param>
	/// <returns><see cref="Task"/></returns>
	Task CreateAsync(IEnumerable<T> entities, CancellationToken cancellationToken = default);

	/// <summary>
	/// Deletes an entity of type <typeparamref name="T"/>.
	/// </summary>
	/// <param name="entity">The entity to delete.</param>
	void Delete(T entity);

	/// <summary>
	/// Deletes an entity of type <typeparamref name="T"/>.
	/// </summary>
	/// <param name="entity">The entity to delete.</param>
	/// <returns><see cref="Task"/></returns>
	Task DeleteAsync(T entity);

	/// <summary>
	/// Deletes multiple entities of type <typeparamref name="T"/>.
	/// </summary>
	/// <param name="entities">The entities to delete.</param>
	void Delete(IEnumerable<T> entities);

	/// <summary>
	/// Deletes multiple entities of type <typeparamref name="T"/>.
	/// </summary>
	/// <param name="entities">The entities to delete.</param>
	/// <returns><see cref="Task"/></returns>
	Task DeleteAsync(IEnumerable<T> entities);

	/// <summary>
	/// Returns the number of entities of type <typeparamref name="T"/> based on the given criteria.
	/// </summary>
	/// <param name="expression">The condition the entities must fulfill to be counted.</param>
	/// <param name="queryFilter">The function used to filter the entities.</param>
	/// <param name="ignoreQueryFilters">Should model-level entity query filters be applied?</param>
	/// <returns>The number of entities in dependence to the expression.</returns>
	int Count(
		Expression<Func<T, bool>>? expression = null,
		Func<IQueryable<T>, IQueryable<T>>? queryFilter = null,
		bool ignoreQueryFilters = false
		);

	/// <summary>
	/// Returns the number of entities of type <typeparamref name="T"/> based on the given criteria.
	/// </summary>
	/// <param name="expression">The condition the entities must fulfill to be counted.</param>
	/// <param name="queryFilter">The function used to filter the entities.</param>
	/// <param name="ignoreQueryFilters">Should model-level entity query filters be applied?</param>
	/// <param name="cancellationToken">The cancellation token to cancel the request.</param>
	/// <returns>The number of entities in dependence to the expression.</returns>
	Task<int> CountAsync(
		Expression<Func<T, bool>>? expression = null,
		Func<IQueryable<T>, IQueryable<T>>? queryFilter = null,
		bool ignoreQueryFilters = false,
		CancellationToken cancellationToken = default
		);

	/// <summary>
	/// Returns all entries of the <typeparamref name="T"/> entity.
	/// </summary>
	/// <param name="ignoreQueryFilters"></param>
	/// <param name="trackChanges"></param>
	/// <returns></returns>
	IEnumerable<T> GetAll(
		bool ignoreQueryFilters = false,
		bool trackChanges = false
		);

	/// <summary>
	/// Returns all entries of the <typeparamref name="T"/> entity.
	/// </summary>
	/// <param name="ignoreQueryFilters">Should model-level entity query filters be applied?</param>
	/// <param name="trackChanges">Should the fetched entries be tracked?</param>
	/// <param name="cancellationToken">The cancellation token to cancel the request.</param>
	/// <returns>A list of entries.</returns>
	Task<IEnumerable<T>> GetAllAsync(
		bool ignoreQueryFilters = false,
		bool trackChanges = false,
		CancellationToken cancellationToken = default
		);

	/// <summary>
	/// Returns a collection of <typeparamref name="T"/> entities based on the specified criteria.
	/// </summary>
	/// <param name="expression">The condition the entities must fulfill to be returned.</param>
	/// <param name="queryFilter">The function used to filter the entities.</param>
	/// <param name="ignoreQueryFilters">Should model-level entity query filters be applied?</param>
	/// <param name="orderBy">The function used to order the entities.</param>
	/// <param name="take">The number of records to limit the results to.</param>
	/// <param name="skip">The number of records to skip.</param>
	/// <param name="trackChanges">Should the fetched entries be tracked?</param>
	/// <param name="includeProperties">Any other navigation properties to include when returning the collection.</param>
	/// <returns>A collection of entities.</returns>
	IEnumerable<T> GetManyByCondition(
		Expression<Func<T, bool>>? expression = null,
		Func<IQueryable<T>, IQueryable<T>>? queryFilter = null,
		bool ignoreQueryFilters = false,
		Func<IQueryable<T>, IOrderedQueryable<T>>? orderBy = null,
		int? take = null,
		int? skip = null,
		bool trackChanges = false,
		params string[] includeProperties
		);

	/// <summary>
	/// Returns a collection of <typeparamref name="T"/> entities based on the specified criteria.
	/// </summary>
	/// <param name="expression">The condition the entities must fulfill to be returned.</param>
	/// <param name="queryFilter">The function used to filter the entities.</param>
	/// <param name="ignoreQueryFilters">Should model-level entity query filters be applied?</param>
	/// <param name="orderBy">The function used to order the entities.</param>
	/// <param name="take">The number of records to limit the results to.</param>
	/// <param name="skip">The number of records to skip.</param>
	/// <param name="trackChanges">Should the fetched entries be tracked?</param>
	/// <param name="cancellationToken">The cancellation token.</param>
	/// <param name="includeProperties">Any other navigation properties to include when returning the collection.</param>
	/// <returns>A collection of entities.</returns>
	Task<IEnumerable<T>> GetManyByConditionAsync(
		Expression<Func<T, bool>>? expression = null,
		Func<IQueryable<T>, IQueryable<T>>? queryFilter = null,
		bool ignoreQueryFilters = false,
		Func<IQueryable<T>, IOrderedQueryable<T>>? orderBy = null,
		int? take = null,
		int? skip = null,
		bool trackChanges = false,
		CancellationToken cancellationToken = default,
		params string[] includeProperties
		);

	/// <summary>
	/// Returns an entity of type <typeparamref name="T"/> by a certain condition.
	/// </summary>
	/// <param name="expression">The search condition.</param>
	/// <param name="queryFilter">The function used to filter the entities.</param>
	/// <param name="ignoreQueryFilters">Should model-level entity query filters be applied?</param>
	/// <param name="trackChanges">Should the fetched entity be tracked?</param>
	/// <param name="includeProperties">Any other navigation properties to include when returning the entity.</param>
	/// <returns>One entry of an entity.</returns>
	T? GetByCondition(
		Expression<Func<T, bool>> expression,
		Func<IQueryable<T>, IQueryable<T>>? queryFilter = null,
		bool ignoreQueryFilters = false,
		bool trackChanges = false,
		params string[] includeProperties
		);

	/// <summary>
	/// Returns an entity of type <typeparamref name="T"/> by a certain condition.
	/// </summary>
	/// <param name="expression">The search condition.</param>
	/// <param name="queryFilter">The function used to filter the entities.</param>
	/// <param name="ignoreQueryFilters">Should model-level entity query filters be applied?</param>
	/// <param name="trackChanges">Should the fetched entity be tracked?</param>
	/// <param name="cancellationToken">The cancellation token to cancel the request.</param>
	/// <param name="includeProperties">Any other navigation properties to include when returning the entity.</param>
	/// <returns>One entry of an entity.</returns>
	Task<T?> GetByConditionAsync(
		Expression<Func<T, bool>> expression,
		Func<IQueryable<T>, IQueryable<T>>? queryFilter = null,
		bool ignoreQueryFilters = false,
		bool trackChanges = false,
		CancellationToken cancellationToken = default,
		params string[] includeProperties
		);

	/// <summary>
	/// Returns the number of all entities of type <typeparamref name="T"/>.
	/// </summary>
	/// <param name="ignoreQueryFilters">Should model-level entity query filters be applied?</param>
	/// <returns>The number of all entities.</returns>
	int TotalCount(
		bool ignoreQueryFilters = false
		);

	/// <summary>
	/// Returns the number of all entities of type <typeparamref name="T"/>.
	/// </summary>
	/// <param name="ignoreQueryFilters">Should model-level entity query filters be applied?</param>
	/// <param name="cancellationToken">The cancellation token to cancel the request.</param>
	/// <returns>The number of all entities.</returns>
	Task<int> TotalCountAsync(
		bool ignoreQueryFilters = false,
		CancellationToken cancellationToken = default
		);

	/// <summary>
	/// Updates an entity of type <typeparamref name="T"/>.
	/// </summary>
	/// <param name="entity">The entity to update.</param>
	void Update(T entity);

	/// <summary>
	/// Updates an entity of type <typeparamref name="T"/>.
	/// </summary>
	/// <param name="entity">The entity to update.</param>
	/// <returns><see cref="Task"/></returns>
	Task UpdateAsync(T entity);

	/// <summary>
	/// Updates multiple entities of type <typeparamref name="T"/>.
	/// </summary>
	/// <param name="entities">The entities to update.</param>
	void Update(IEnumerable<T> entities);

	/// <summary>
	/// Updates multiple entities of type <typeparamref name="T"/>.
	/// </summary>
	/// <param name="entities">The entities to update.</param>
	/// <returns><see cref="Task"/></returns>
	Task UpdateAsync(IEnumerable<T> entities);
}
