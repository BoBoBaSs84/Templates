using DomainName.Application.Abstractions.Infrastructure.Persistence;
using DomainName.Domain.Entities;
using DomainName.Infrastructure.Common;

using Microsoft.EntityFrameworkCore;

namespace DomainName.Infrastructure.Persistence;

/// <summary>
/// Represents the database context for the application, providing access to the entities.
/// </summary>
/// <param name="dbContextOptions">The options to configure the database context.</param>
internal sealed class DatabaseContext(DbContextOptions<DatabaseContext> dbContextOptions) : DbContext(dbContextOptions), IDatabaseContext
{
	public DbSet<TodoList> TodoLists { get; set; } = default!;
	public DbSet<TodoItem> TodoItems { get; set; } = default!;

	/// <inheritdoc/>
	protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
	{
		base.OnConfiguring(optionsBuilder);

		optionsBuilder.AddInterceptors([]);
	}

	/// <inheritdoc/>
	protected override void OnModelCreating(ModelBuilder modelBuilder)
	{
		base.OnModelCreating(modelBuilder);

		modelBuilder.ApplyConfigurationsFromAssembly(typeof(IInfrastructureAssemblyMarker).Assembly);
	}
}
