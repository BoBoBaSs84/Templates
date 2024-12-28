using BB84.EntityFrameworkCore.Entities.Abstractions.Components;

using DomainName.Application.Interfaces.Application.Services;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore.Diagnostics;

namespace DomainName.Infrastructure.Persistence.Interceptors;

/// <summary>
/// The user audit save changes interceptor.
/// </summary>
/// <param name="userService">The user service instance to use.</param>
public sealed class UserAuditSaveChangesInterceptor(IUserService userService) : SaveChangesInterceptor
{
	private readonly IUserService _userService = userService;

	/// <inheritdoc/>
	public override InterceptionResult<int> SavingChanges(DbContextEventData eventData, InterceptionResult<int> result)
	{
		InterceptEntities(eventData.Context);
		return base.SavingChanges(eventData, result);
	}

	/// <inheritdoc/>
	public override ValueTask<InterceptionResult<int>> SavingChangesAsync(DbContextEventData eventData, InterceptionResult<int> result, CancellationToken cancellationToken = default)
	{
		InterceptEntities(eventData.Context);
		return base.SavingChangesAsync(eventData, result, cancellationToken);
	}

	private void InterceptEntities(DbContext? context)
	{
		if (context is not null)
		{
			foreach (EntityEntry<IUserAudited> entityEntry in context.ChangeTracker.Entries<IUserAudited>())
			{
				switch (entityEntry.State)
				{
					case EntityState.Modified:
						entityEntry.Entity.Editor = _userService.User;
						break;
					case EntityState.Added:
						entityEntry.Entity.Creator = _userService.User;
						break;
				}
			}
		}
	}
}
