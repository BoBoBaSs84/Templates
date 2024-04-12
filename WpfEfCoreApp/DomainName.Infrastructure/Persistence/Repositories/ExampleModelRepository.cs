using BB84.EntityFrameworkCore.Repositories;

using DomainName.Application.Interfaces.Infrastructure.Persistence.Repositories;
using DomainName.Domain.Models;

using Microsoft.EntityFrameworkCore;

namespace DomainName.Infrastructure.Persistence.Repositories;

/// <summary>
/// The example model repository class.
/// </summary>
/// <inheritdoc/>
internal sealed class ExampleModelRepository(DbContext dbContext) : IdentityRepository<ExampleModel>(dbContext), IExampleModelRepository
{ }
