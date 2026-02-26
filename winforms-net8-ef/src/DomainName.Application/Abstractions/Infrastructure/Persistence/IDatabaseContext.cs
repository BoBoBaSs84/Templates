using BB84.EntityFrameworkCore.Repositories.Abstractions;

namespace DomainName.Application.Abstractions.Infrastructure.Persistence;

/// <summary>
/// Represents the interface for the application database context.
/// </summary>
public interface IDatabaseContext : IDbContext
{ }
