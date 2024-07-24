using DomainName.Domain.Models;

using Microsoft.EntityFrameworkCore;

namespace DomainName.Infrastructure.Persistence;

public sealed partial class RepositoryContext
{
	/// <inheritdoc />
	public DbSet<ExampleModel> Examples { get; set; }
}
