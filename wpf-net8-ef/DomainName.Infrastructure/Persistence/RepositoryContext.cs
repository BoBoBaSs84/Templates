using System.Diagnostics.CodeAnalysis;

using DomainName.Application.Interfaces.Infrastructure.Persistence;
using DomainName.Infrastructure.Common;
using DomainName.Infrastructure.Persistence.Interceptors;

using Microsoft.EntityFrameworkCore;

namespace DomainName.Infrastructure.Persistence;

/// <summary>
/// The repository context class.
/// </summary>
/// <param name="options">The context options to use.</param>
/// <param name="changesInterceptor">The save changes interceptor to use.</param>
[SuppressMessage("Style", "IDE0058", Justification = "Not relevant here, context configuration.")]
public sealed partial class RepositoryContext(DbContextOptions<RepositoryContext> options, UserAuditSaveChangesInterceptor changesInterceptor) : DbContext(options), IRepositoryContext
{
	/// <inheritdoc/>
	protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		=> optionsBuilder.AddInterceptors(changesInterceptor);

	/// <inheritdoc/>
	protected override void OnModelCreating(ModelBuilder modelBuilder)
	{
		base.OnModelCreating(modelBuilder);

		modelBuilder.ApplyConfigurationsFromAssembly(typeof(IInfrastructureAssemblyMarker).Assembly);
	}
}
