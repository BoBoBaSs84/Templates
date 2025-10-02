using BB84.EntityFrameworkCore.Repositories.Abstractions;

using DomainName.Domain.Entities;

using Microsoft.EntityFrameworkCore;

namespace DomainName.Application.Abstractions.Infrastructure.Persistence;

/// <summary>
/// The interface for the application database context.
/// </summary>
public interface IDatabaseContext : IDbContext
{
	/// <summary>
	/// Gets the DbSet for TodoList entities.
	/// </summary>
	public DbSet<TodoList> TodoLists { get; }

	/// <summary>
	/// Gets the DbSet for TodoItem entities.
	/// </summary>
	public DbSet<TodoItem> TodoItems { get; }
}
