using BB84.EntityFrameworkCore.Repositories.Abstractions;

using DomainName.Application.Abstractions.Application.Services;
using DomainName.Application.Abstractions.Infrastructure.Services;
using DomainName.Application.Contracts;
using DomainName.Application.Features;
using DomainName.Application.Interfaces.Infrastructure.Services;
using DomainName.Domain.Entities;
using DomainName.Infrastructure.Extensions;

using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace DomainName.Application.Services;

internal sealed class ExampleService(ILoggerService<ExampleService> loggerService, IServiceScopeFactory scopeFactory) : IExampleService
{
	private static readonly Action<ILogger, string, Exception?> LogError =
		LoggerMessage.Define<string>(LogLevel.Critical, 0, "{Error}");

	public async Task<IPagedList<ExampleEntity>> GetPagedListAsync(ExampleEntityQuery queryFilter, CancellationToken cancellationToken = default)
	{
		using IServiceScope scope = scopeFactory.CreateScope();
		IRepositoryService repositoryService = scope.ServiceProvider.GetRequiredService<IRepositoryService>();

		try
		{
			Query<ExampleEntity> query = new()
			{
				OrderBy = qe => qe.OrderBy(ee => ee.LastName).ThenBy(ee => ee.FirstName),
				Skip = queryFilter.Skip,
				Take = queryFilter.PageSize,
				QueryFilter = qf => qf.FilterByLastName(queryFilter.LastName).FilterByFirstName(queryFilter.FirstName).FilterByAge(queryFilter.Age)
			};

			IReadOnlyList<ExampleEntity> list = await repositoryService.ExampleRepository
				.GetListAsync(query, cancellationToken)
				.ConfigureAwait(false);

			int totalCount = await repositoryService.ExampleRepository
				.CountAsync(new() { QueryFilter = query.QueryFilter }, cancellationToken)
				.ConfigureAwait(false);

			return new PagedList<ExampleEntity>(list, totalCount, queryFilter.PageNumber, queryFilter.PageSize);
		}
		catch (Exception ex)
		{
			loggerService.Log(LogError, "An error occurred while retrieving the paged list of example entities.", ex);
			throw;
		}
	}
}
