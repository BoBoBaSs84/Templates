using DomainName.Application.Interfaces.Infrastructure.Services;
using DomainName.Infrastructure.Persistence;

namespace DomainName.Infrastructure.Services;

/// <summary>
/// The repository service class.
/// </summary>
/// <param name="context">The database context to use.</param>
internal sealed partial class RepositoryService(RepositoryContext context) : IRepositoryService
{
	private readonly RepositoryContext _context = context;

	public int CommitChanges()
		=> _context.SaveChanges();

	public async Task<int> CommitChangesAsync(CancellationToken cancellationToken = default)
		=> await _context.SaveChangesAsync(cancellationToken);
}
