using DomainName.Application.Abstractions.Infrastructure.Persistence;
using DomainName.Infrastructure.Common;

using Microsoft.EntityFrameworkCore;

namespace DomainName.Infrastructure.Persistence;

internal sealed class DatabaseContext(DbContextOptions<DatabaseContext> options) : DbContext(options), IDatabaseContext
{
	/// <inheritdoc/>
	protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
	{
		base.OnConfiguring(optionsBuilder);

		_ = optionsBuilder.AddInterceptors([]);
	}

	/// <inheritdoc/>
	protected override void OnModelCreating(ModelBuilder modelBuilder)
	{
		base.OnModelCreating(modelBuilder);

		_ = modelBuilder.ApplyConfigurationsFromAssembly(typeof(IInfrastructureAssemblyMarker).Assembly);
	}
}
