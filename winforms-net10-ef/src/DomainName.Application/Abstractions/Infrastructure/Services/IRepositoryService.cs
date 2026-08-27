using DomainName.Application.Abstractions.Infrastructure.Persistence.Repositories;

namespace DomainName.Application.Abstractions.Infrastructure.Services;

/// <summary>
/// Represents the interface for managing the application repositories.
/// </summary>
public interface IRepositoryService
{
	/// <summary>
	/// Gets the todo interface.
	/// </summary>
	ITodoRepository Todos { get; }
}
