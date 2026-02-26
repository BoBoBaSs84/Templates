using DomainName.Application.Abstractions.Infrastructure.Persistence;
using DomainName.Application.Abstractions.Infrastructure.Persistence.Repositories;
using DomainName.Domain.Entities;
using DomainName.Infrastructure.Persistence.Repositories.Base;

namespace DomainName.Infrastructure.Persistence.Repositories;

/// <summary>
/// Represents the repository for managing the <see cref="TodoEntity"/>.
/// </summary>
internal sealed class TodoRepository(IDatabaseContext dbContext)
	: BaseRepository<TodoEntity>(dbContext), ITodoRepository
{ }
