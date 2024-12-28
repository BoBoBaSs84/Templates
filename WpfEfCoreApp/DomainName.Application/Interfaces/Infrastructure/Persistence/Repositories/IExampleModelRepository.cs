using BB84.EntityFrameworkCore.Repositories.Abstractions;

using DomainName.Domain.Entities;

namespace DomainName.Application.Interfaces.Infrastructure.Persistence.Repositories;

/// <summary>
/// The example model repository interface.
/// </summary>
public interface IExampleModelRepository : IIdentityRepository<ExampleEntity>
{ }
