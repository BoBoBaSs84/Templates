using DomainName.Domain.Entities;

using Microsoft.EntityFrameworkCore;

namespace DomainName.Infrastructure.Persistence;

public sealed partial class RepositoryContext
{
	/// <inheritdoc />
	public DbSet<ExampleEntity> Examples { get; set; }
}
