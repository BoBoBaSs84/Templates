using DomainName.Application.Abstractions.Infrastructure.Persistence;
using DomainName.Application.Abstractions.Infrastructure.Persistence.Repositories;
using DomainName.Application.Abstractions.Infrastructure.Services;
using DomainName.Infrastructure.Persistence.Repositories;

namespace DomainName.Infrastructure.Services;

/// <summary>
/// Represents the repository service for accessing the repositories.
/// </summary>
/// <param name="databaseContext"></param>
internal sealed class RepositoryService(IDatabaseContext databaseContext) : IRepositoryService
{
	private readonly Lazy<ITodoRepository> _todoRepository = new(() => new TodoRepository(databaseContext));

	public ITodoRepository Todos => _todoRepository.Value;
}
