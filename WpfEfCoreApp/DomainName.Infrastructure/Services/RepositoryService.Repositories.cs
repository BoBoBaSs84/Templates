using DomainName.Application.Interfaces.Infrastructure.Persistence.Repositories;
using DomainName.Infrastructure.Persistence.Repositories;

namespace DomainName.Infrastructure.Services;

internal sealed partial class RepositoryService
{
	private readonly Lazy<ExampleModelRepository> _exampleModelRepository = new(() => new(context));

	public IExampleModelRepository ExampleRepository => _exampleModelRepository.Value;
}
