using DomainName.Application.Contracts;
using DomainName.Application.Features;
using DomainName.Domain.Entities;

namespace DomainName.Application.Abstractions.Application.Services;

/// <summary>
/// Represents the interface for the example service, providing methods for managing example entities.
/// </summary>
public interface IExampleService
{
	/// <summary>
	/// Returns a paged list of example entities based on the provided query parameters.
	/// </summary>
	/// <param name="query">The query parameters for filtering and pagination.</param>
	/// <param name="cancellationToken">The cancellation token.</param>
	/// <returns>
	/// A task representing the asynchronous operation, containing the paged list of example entities.
	/// </returns>
	Task<IPagedList<ExampleEntity>> GetPagedListAsync(ExampleEntityQuery query, CancellationToken cancellationToken = default);
}
