using DomainName.Application.Interfaces.Presentation.Services;

namespace DomainName.Presentation.Services;

/// <summary>
/// The current user service.
/// </summary>
internal sealed class CurrentUserService : ICurrentUserService
{
	/// <inheritdoc/>
	public string UserName => Environment.UserName;

	/// <inheritdoc/>
	public string UserDomainName => Environment.UserDomainName;

	/// <inheritdoc/>
	public string MachineName => Environment.MachineName;
}
