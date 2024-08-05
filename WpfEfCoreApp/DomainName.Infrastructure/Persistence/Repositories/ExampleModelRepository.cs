using BB84.EntityFrameworkCore.Repositories;

using DomainName.Application.Interfaces.Infrastructure.Persistence;
using DomainName.Application.Interfaces.Infrastructure.Persistence.Repositories;
using DomainName.Domain.Models;

namespace DomainName.Infrastructure.Persistence.Repositories;

/// <summary>
/// The example model repository class.
/// </summary>
/// <param name="context">The database context to use.</param>
internal sealed class ExampleModelRepository(IRepositoryContext context) : IdentityRepository<ExampleModel>(context), IExampleModelRepository
{ }
