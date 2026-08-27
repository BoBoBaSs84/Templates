using DomainName.Application.Abstractions.Infrastructure.Persistence.Repositories.Base;
using DomainName.Domain.Entities;

namespace DomainName.Application.Abstractions.Infrastructure.Persistence.Repositories;

/// <summary>
/// Represents the repository interface for managing the <see cref="TodoEntity"/>.
/// </summary>
public interface ITodoRepository : IBaseRepository<TodoEntity>
{ }
