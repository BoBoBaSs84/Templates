using DomainName.Application.Interfaces.Application.Services;
using DomainName.Domain.Models.Base;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore.Diagnostics;

namespace DomainName.Infrastructure.Persistence.Interceptors;

/// <summary>
/// The custom save changes interceptor class.
/// </summary>
/// <param name="userService">The user service instance to use.</param>
public sealed class CustomSaveChangesInterceptor(IUserService userService) : SaveChangesInterceptor
{
	private readonly IUserService _userService = userService;

	/// <inheritdoc/>
	public override InterceptionResult<int> SavingChanges(DbContextEventData eventData, InterceptionResult<int> result)
	{
		Intercept(eventData.Context);
		return base.SavingChanges(eventData, result);
	}

	/// <inheritdoc/>
	public override ValueTask<InterceptionResult<int>> SavingChangesAsync(DbContextEventData eventData, InterceptionResult<int> result, CancellationToken cancellationToken = default)
	{
		Intercept(eventData.Context);
		return base.SavingChangesAsync(eventData, result, cancellationToken);
	}

	private void Intercept(DbContext? context)
	{
		if (context is null)
			return;

		foreach (EntityEntry<DataModelBase> entry in context.ChangeTracker.Entries<DataModelBase>())
		{
			if (entry.State is EntityState.Deleted or EntityState.Modified)
				entry.Entity.ModifiedBy = _userService.User;

			if (entry.State is EntityState.Added)
				entry.Entity.CreatedBy = _userService.User;
		}
	}
}
