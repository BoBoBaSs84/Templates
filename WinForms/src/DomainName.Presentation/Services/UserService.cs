using DomainName.Application.Abstractions.Presentation.Services;

namespace DomainName.Presentation.Services;

/// <summary>
/// The user service implementation.
/// </summary>
internal sealed class UserService : IUserService
{
	/// <inheritdoc/>
	public string Name => Environment.UserName;

	/// <inheritdoc/>
	public string Domain => Environment.UserDomainName;

	/// <inheritdoc/>
	public string Machine => Environment.MachineName;
}
