using System.Diagnostics.CodeAnalysis;
using System.Linq.Expressions;

using DomainName.Application.Interfaces.Infrastructure.Persistence.Repositories.Base;

using Microsoft.EntityFrameworkCore;

namespace DomainName.Infrastructure.Persistence.Repositories.Base;

/// <summary>
/// The generic repository class.
/// </summary>
/// <typeparam name="T">The type to work with.</typeparam>
[SuppressMessage("Style", "IDE0058", Justification = "Not relevant here, generic repository.")]
internal abstract class GenericRepository<T> : IGenericRepository<T> where T : class
{
	protected DbContext _dbContext;
	protected DbSet<T> _dbSet;

	/// <summary>
	/// Initializes a new instance of the <see cref="GenericRepository{T}"/> class.
	/// </summary>
	/// <remarks>
	/// Any context that inherits from <see cref="DbContext"/> should work.
	/// </remarks>
	/// <param name="dbContext">The database context to work with.</param>	
	protected GenericRepository(DbContext dbContext)
	{
		_dbContext = dbContext;
		_dbSet = dbContext.Set<T>();
	}

	public void Create(T entity)
		=> _dbSet.Add(entity);

	public void Create(IEnumerable<T> entities)
		=> _dbSet.AddRange(entities);

	public async Task CreateAsync(T entity, CancellationToken cancellationToken = default)
		=> await _dbSet.AddAsync(entity, cancellationToken);

	public async Task CreateAsync(IEnumerable<T> entities, CancellationToken cancellationToken = default)
		=> await _dbSet.AddRangeAsync(entities, cancellationToken);

	public int Count(
		Expression<Func<T, bool>>? expression = null,
		Func<IQueryable<T>, IQueryable<T>>? queryFilter = null,
		bool ignoreQueryFilters = false)
	{
		IQueryable<T> query = PrepareQuery(
			expression, queryFilter, ignoreQueryFilters
			);

		return query.Count();
	}

	public async Task<int> CountAsync(
		Expression<Func<T, bool>>? expression = null,
		Func<IQueryable<T>, IQueryable<T>>? queryFilter = null,
		bool ignoreQueryFilters = false,
		CancellationToken cancellationToken = default)
	{
		IQueryable<T> query = PrepareQuery(
			expression, queryFilter, ignoreQueryFilters
			);

		return await query.CountAsync(cancellationToken);
	}

	public void Delete(T entity)
		=> _dbSet.Remove(entity);

	public void Delete(IEnumerable<T> entities)
		=> _dbSet.RemoveRange(entities);

	public Task DeleteAsync(T entity)
	{
		_dbSet.Remove(entity);
		return Task.CompletedTask;
	}

	public Task DeleteAsync(IEnumerable<T> entities)
	{
		_dbSet.RemoveRange(entities);
		return Task.CompletedTask;
	}

	public IEnumerable<T> GetAll(
		bool ignoreQueryFilters = false,
		bool trackChanges = false)
	{
		IQueryable<T> query = PrepareQuery(
			ignoreQueryFilters: ignoreQueryFilters,
			trackChanges: trackChanges
			);

		return query.ToList();
	}

	public async Task<IEnumerable<T>> GetAllAsync(
		bool ignoreQueryFilters = false,
		bool trackChanges = false,
		CancellationToken cancellationToken = default)
	{
		IQueryable<T> query = PrepareQuery(
			ignoreQueryFilters: ignoreQueryFilters,
			trackChanges: trackChanges
			);

		return await query.ToListAsync(cancellationToken);
	}

	public T? GetByCondition(
		Expression<Func<T, bool>> expression,
		Func<IQueryable<T>, IQueryable<T>>? queryFilter = null,
		bool ignoreQueryFilters = false,
		bool trackChanges = false,
		params string[] includeProperties)
	{
		IQueryable<T> query = PrepareQuery(
			expression, queryFilter, ignoreQueryFilters,
			trackChanges: trackChanges,
			includeProperties: includeProperties
			);

		return query.SingleOrDefault();
	}

	public async Task<T?> GetByConditionAsync(
		Expression<Func<T, bool>> expression,
		Func<IQueryable<T>, IQueryable<T>>? queryFilter = null,
		bool ignoreQueryFilters = false,
		bool trackChanges = false,
		CancellationToken cancellationToken = default,
		params string[] includeProperties)
	{
		IQueryable<T> query = PrepareQuery(
			expression, queryFilter, ignoreQueryFilters,
			trackChanges: trackChanges,
			includeProperties: includeProperties
			);

		return await query.SingleOrDefaultAsync(cancellationToken);
	}

	public IEnumerable<T> GetManyByCondition(
		Expression<Func<T, bool>>? expression = null,
		Func<IQueryable<T>, IQueryable<T>>? queryFilter = null,
		bool ignoreQueryFilters = false,
		Func<IQueryable<T>, IOrderedQueryable<T>>? orderBy = null,
		int? take = null,
		int? skip = null,
		bool trackChanges = false,
		params string[] includeProperties)
	{
		IQueryable<T> query = PrepareQuery(
			expression, queryFilter, ignoreQueryFilters, orderBy, take, skip, trackChanges, includeProperties
			);

		return query.ToList();
	}

	public async Task<IEnumerable<T>> GetManyByConditionAsync(
		Expression<Func<T, bool>>? expression = null,
		Func<IQueryable<T>, IQueryable<T>>? queryFilter = null,
		bool ignoreQueryFilters = false,
		Func<IQueryable<T>, IOrderedQueryable<T>>? orderBy = null,
		int? take = null,
		int? skip = null,
		bool trackChanges = false,
		CancellationToken cancellationToken = default,
		params string[] includeProperties)
	{
		IQueryable<T> query = PrepareQuery(
			expression, queryFilter, ignoreQueryFilters, orderBy, take, skip, trackChanges, includeProperties
			);

		return await query.ToListAsync(cancellationToken);
	}

	public int TotalCount(bool ignoreQueryFilters = false)
	{
		IQueryable<T> query = PrepareQuery(
			ignoreQueryFilters: ignoreQueryFilters
			);

		return query.Count();
	}

	public async Task<int> TotalCountAsync(bool ignoreQueryFilters = false, CancellationToken cancellationToken = default)
	{
		IQueryable<T> query = PrepareQuery(
			ignoreQueryFilters: ignoreQueryFilters
			);

		return await query.CountAsync(cancellationToken);
	}

	public void Update(T entity)
		=> _dbSet.Update(entity);

	public void Update(IEnumerable<T> entities)
		=> _dbSet.UpdateRange(entities);

	public Task UpdateAsync(T entity)
	{
		_dbSet.Update(entity);
		return Task.CompletedTask;
	}

	public Task UpdateAsync(IEnumerable<T> entities)
	{
		_dbSet.UpdateRange(entities);
		return Task.CompletedTask;
	}

	protected IQueryable<T> PrepareQuery(
		Expression<Func<T, bool>>? expression = null,
		Func<IQueryable<T>, IQueryable<T>>? queryFilter = null,
		bool ignoreQueryFilters = false,
		Func<IQueryable<T>, IOrderedQueryable<T>>? orderBy = null,
		int? take = null,
		int? skip = null,
		bool trackChanges = false,
		params string[] includeProperties)
	{
		IQueryable<T> query = !trackChanges ? _dbSet.AsNoTracking() : _dbSet;

		if (expression is not null)
			query = query.Where(expression);

		if (queryFilter is not null)
			query = queryFilter(query);

		if (ignoreQueryFilters)
			query = query.IgnoreQueryFilters();

		if (includeProperties.Length > 0)
			query = includeProperties.Aggregate(query, (theQuery, theInclude) => theQuery.Include(theInclude));

		if (orderBy is not null)
			query = orderBy(query);

		if (skip.HasValue)
			query = query.Skip(skip.Value);

		if (take.HasValue)
			query = query.Take(take.Value);

		return query;
	}
}
