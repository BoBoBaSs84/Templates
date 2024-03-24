using DomainName.Application.Interfaces.Infrastructure.Persistence.Repositories.Base;
using DomainName.Domain.Models.Base;

using Microsoft.EntityFrameworkCore;

namespace DomainName.Infrastructure.Persistence.Repositories.Base;

/// <summary>
/// The enumerator repository class.
/// </summary>
/// <inheritdoc/>
internal abstract class EnumeratorRepository<T>(DbContext dbContext) : GenericRepository<T>(dbContext), IEnumeratorRepository<T> where T : EnumeratorModelBase
{
	public T? GetById(int id, bool ignoreQueryFilters = false, bool trackChanges = false)
	{
		IQueryable<T> query = PrepareQuery(
			expression: x => x.Id.Equals(id),
			ignoreQueryFilters: ignoreQueryFilters,
			trackChanges: trackChanges
			);

		return query.SingleOrDefault();
	}

	public async Task<T?> GetByIdAsync(int id, bool ignoreQueryFilters = false, bool trackChanges = false, CancellationToken cancellationToken = default)
	{
		IQueryable<T> query = PrepareQuery(
			expression: x => x.Id.Equals(id),
			ignoreQueryFilters: ignoreQueryFilters,
			trackChanges: trackChanges
			);

		return await query.SingleOrDefaultAsync(cancellationToken);
	}

	public IEnumerable<T> GetByIds(IEnumerable<int> ids, bool ignoreQueryFilters = false, bool trackChanges = false)
	{
		IQueryable<T> query = PrepareQuery(
			expression: x => ids.Contains(x.Id),
			ignoreQueryFilters: ignoreQueryFilters,
			trackChanges: trackChanges
			);

		return [.. query];
	}

	public async Task<IEnumerable<T>> GetByIdsAsync(IEnumerable<int> ids, bool ignoreQueryFilters = false, bool trackChanges = false, CancellationToken cancellationToken = default)
	{
		IQueryable<T> query = PrepareQuery(
			expression: x => ids.Contains(x.Id),
			ignoreQueryFilters: ignoreQueryFilters,
			trackChanges: trackChanges
			);

		return await query.ToListAsync(cancellationToken);
	}

	public T? GetByName(string name, bool ignoreQueryFilters = false, bool trackChanges = false)
	{
		IQueryable<T> query = PrepareQuery(
			expression: x => x.Name == name,
			ignoreQueryFilters: ignoreQueryFilters,
			trackChanges: trackChanges
			);

		return query.SingleOrDefault();
	}

	public async Task<T?> GetByName(string name, bool ignoreQueryFilters = false, bool trackChanges = false, CancellationToken cancellationToken = default)
	{
		IQueryable<T> query = PrepareQuery(
			expression: x => x.Name == name,
			ignoreQueryFilters: ignoreQueryFilters,
			trackChanges: trackChanges
			);

		return await query.SingleOrDefaultAsync(cancellationToken);
	}
}
