using DomainName.Application.Interfaces.Infrastructure.Persistence.Repositories;

namespace DomainName.Application.Interfaces.Infrastructure.Services;

public partial interface IRepositoryService
{
	/// <summary>
	/// The example repository instance.
	/// </summary>
	IExampleModelRepository ExampleRepository { get; }
}
