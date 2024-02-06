using System.Diagnostics.CodeAnalysis;

using DomainName.Application.Interfaces.Infrastructure.Services;
using DomainName.Infrastructure.Common;
using DomainName.Infrastructure.Persistence.Interceptors;

using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace DomainName.Infrastructure.Persistence;

/// <summary>
/// The repository context class.
/// </summary>
/// <param name="options">The context options to use.</param>
/// <param name="changesInterceptor">The save changes interceptor to use.</param>
/// <param name="loggerService">The logger service instance to use.</param>
[SuppressMessage("Style", "IDE0058", Justification = "Not relevant here, context configuration.")]
public sealed partial class RepositoryContext(DbContextOptions<RepositoryContext> options, CustomSaveChangesInterceptor changesInterceptor, ILoggerService<RepositoryContext> loggerService) : DbContext(options)
{
	private readonly CustomSaveChangesInterceptor _changesInterceptor = changesInterceptor;
	private readonly ILoggerService<RepositoryContext> _loggerService = loggerService;

	private static readonly Action<ILogger, Exception?> LogException =
		LoggerMessage.Define(LogLevel.Error, 0, "Exception occured.");

	/// <inheritdoc/>
	protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		=> optionsBuilder.AddInterceptors(_changesInterceptor);

	/// <inheritdoc/>
	protected override void OnModelCreating(ModelBuilder modelBuilder)
	{
		base.OnModelCreating(modelBuilder);

		modelBuilder.ApplyConfigurationsFromAssembly(typeof(IInfrastructureAssemblyMarker).Assembly);
	}

	/// <inheritdoc/>
	public override async Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
	{
		int result = default;
		try
		{
			result = await base.SaveChangesAsync(cancellationToken);
		}
		catch (Exception ex)
		{
			_loggerService.Log(LogException, ex);
		}
		return result;
	}

	/// <inheritdoc/>
	public override int SaveChanges()
	{
		int result = default;
		try
		{
			result = base.SaveChanges();
		}
		catch (Exception ex)
		{
			_loggerService.Log(LogException, ex);
		}
		return result;
	}
}
