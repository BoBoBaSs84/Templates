using BB84.EntityFrameworkCore.Repositories.Abstractions;

using DomainName.Domain.Models;

namespace DomainName.Application.Interfaces.Infrastructure.Persistence.Repositories;

/// <summary>
/// The example model repository interface.
/// </summary>
public interface IExampleModelRepository : IIdentityRepository<ExampleModel>
{ }
