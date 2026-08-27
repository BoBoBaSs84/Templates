using BB84.EntityFrameworkCore.Repositories.Abstractions;

using DomainName.Domain.Abstractions.Entities.Base;

namespace DomainName.Application.Abstractions.Infrastructure.Persistence.Repositories.Base;

/// <summary>
/// Represents the base repository interface for managing entities.
/// </summary>
/// <typeparam name="T">The entity to manage.</typeparam>
public interface IBaseRepository<T> : IGenericRepository<T> where T : class, IEntityBase
{ }
