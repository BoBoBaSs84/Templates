using BB84.EntityFrameworkCore.Repositories.Abstractions;

using DomainName.Domain.Entities;

using Microsoft.EntityFrameworkCore;

namespace DomainName.Application.Interfaces.Infrastructure.Persistence;

/// <summary>
/// The interface for the repository context.
/// </summary>
public interface IRepositoryContext : IDbContext
{
	/// <summary>
	/// The example model record set.
	/// </summary>
	DbSet<ExampleEntity> Examples { get; set; }
}
