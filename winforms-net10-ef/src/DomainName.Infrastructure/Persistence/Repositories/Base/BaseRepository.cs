using BB84.EntityFrameworkCore.Repositories;

using DomainName.Application.Abstractions.Infrastructure.Persistence;
using DomainName.Application.Abstractions.Infrastructure.Persistence.Repositories.Base;
using DomainName.Domain.Abstractions.Entities.Base;

namespace DomainName.Infrastructure.Persistence.Repositories.Base;

/// <summary>
/// Represents the base repository for managing entities.
/// </summary>
/// <typeparam name="T">The entity to manage.</typeparam>
/// <param name="dbContext">The database context to work with.</param>
internal abstract class BaseRepository<T>(IDatabaseContext dbContext)
	: GenericRepository<T>(dbContext), IBaseRepository<T> where T : class, IEntityBase
{ }
