using DomainName.Domain.Models;

using Microsoft.EntityFrameworkCore;

namespace DomainName.Infrastructure.Persistence;

public sealed partial class RepositoryContext
{
	/// <summary>
	/// The example model record set.
	/// </summary>
	public DbSet<ExampleModel> Examples { get; set; }
}
