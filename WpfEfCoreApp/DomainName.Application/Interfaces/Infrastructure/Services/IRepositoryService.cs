namespace DomainName.Application.Interfaces.Infrastructure.Services;

/// <summary>
/// The repository service interface.
/// </summary>
public partial interface IRepositoryService
{
	/// <summary>
	/// Commits all the changes to the database context async.
	/// </summary>
	/// <param name="cancellationToken">The cancellation token.</param>
	/// <returns>From the commit affected changes.</returns>
	Task<int> CommitChangesAsync(CancellationToken cancellationToken = default);

	/// <summary>
	/// Commits all the changes to the database context.
	/// </summary>
	/// <returns>From the commit affected changes.</returns>
	int CommitChanges();
}
