using DomainName.Application.Interfaces.Infrastructure.Services;
using DomainName.Infrastructure.Interfaces.Persistence;

namespace DomainName.Infrastructure.Services;

/// <summary>
/// The repository service class.
/// </summary>
/// <param name="context">The database context to use.</param>
internal sealed partial class RepositoryService(IRepositoryContext context) : IRepositoryService
{
	private readonly IRepositoryContext _context = context;

	public int SaveChanges()
		=> _context.SaveChanges();

	public async Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
		=> await _context.SaveChangesAsync(cancellationToken);
}
