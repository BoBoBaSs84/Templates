using DomainName.Application.Interfaces.Infrastructure.Persistence.Repositories.Base;
using DomainName.Domain.Models.Base;

using Microsoft.EntityFrameworkCore;

namespace DomainName.Infrastructure.Persistence.Repositories.Base;

/// <summary>
/// The identity repository class.
/// </summary>
/// <typeparam name="T">The type to work with.</typeparam>
internal abstract class IdentityRepository<T> : GenericRepository<T>, IIdentityRepository<T> where T : DataModelBase
{
	/// <summary>
	/// Initializes an instance of <see cref="IdentityRepository{T}"/> class.
	/// </summary>
	/// <inheritdoc/>
	protected IdentityRepository(DbContext dbContext) : base(dbContext)
	{ }

	public T? GetById(Guid id, bool ignoreQueryFilters = false, bool trackChanges = false)
	{
		IQueryable<T> query = !trackChanges ? _dbSet.AsNoTracking() : _dbSet;

		query = query.Where(x => x.Id.Equals(id));

		if (ignoreQueryFilters)
			query = query.IgnoreQueryFilters();

		return query.SingleOrDefault();
	}

	public async Task<T?> GetByIdAsync(Guid id, bool ignoreQueryFilters = false, bool trackChanges = false, CancellationToken cancellationToken = default)
	{
		IQueryable<T> query = !trackChanges ? _dbSet.AsNoTracking() : _dbSet;

		query = query.Where(x => x.Id.Equals(id));

		if (ignoreQueryFilters)
			query = query.IgnoreQueryFilters();

		return await query.SingleOrDefaultAsync(cancellationToken);
	}

	public IEnumerable<T> GetByIds(IEnumerable<Guid> ids, bool ignoreQueryFilters = false, bool trackChanges = false)
	{
		IQueryable<T> query = !trackChanges ? _dbSet.AsNoTracking() : _dbSet;

		query = query.Where(x => ids.Contains(x.Id));

		if (ignoreQueryFilters)
			query = query.IgnoreQueryFilters();

		return query.ToList();
	}

	public async Task<IEnumerable<T>> GetByIdsAsync(IEnumerable<Guid> ids, bool ignoreQueryFilters = false, bool trackChanges = false, CancellationToken cancellationToken = default)
	{
		IQueryable<T> query = !trackChanges ? _dbSet.AsNoTracking() : _dbSet;

		query = query.Where(x => ids.Contains(x.Id));

		if (ignoreQueryFilters)
			query = query.IgnoreQueryFilters();

		return await query.ToListAsync(cancellationToken);
	}
}
