using System.Diagnostics.CodeAnalysis;

using DomainName.Application.Abstractions.Application.Services;
using DomainName.Application.Abstractions.Presentation.Services;

namespace DomainName.Presentation.Services;

/// <summary>
/// The user service implementation.
/// </summary>
/// <param name="providerService">The provider service instance to use for accessing environment information.</param>
[ExcludeFromCodeCoverage]
internal sealed class UserService(IProviderService providerService) : IUserService
{
	/// <inheritdoc/>
	public string Name => providerService.Environment.UserName;

	/// <inheritdoc/>
	public string Domain => providerService.Environment.UserDomainName;

	/// <inheritdoc/>
	public string Machine => providerService.Environment.MachineName;
}
