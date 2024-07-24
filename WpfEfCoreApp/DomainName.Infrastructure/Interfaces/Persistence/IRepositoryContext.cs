using BB84.EntityFrameworkCore.Repositories.Abstractions;

using DomainName.Domain.Models;

using Microsoft.EntityFrameworkCore;

namespace DomainName.Infrastructure.Interfaces.Persistence;

/// <summary>
/// The interface for the repository context.
/// </summary>
public interface IRepositoryContext : IDbContext
{
	/// <summary>
	/// The example model record set.
	/// </summary>
	DbSet<ExampleModel> Examples { get; set; }
}
