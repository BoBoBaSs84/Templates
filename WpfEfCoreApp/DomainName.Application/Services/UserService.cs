using DomainName.Application.Interfaces.Application.Services;

namespace DomainName.Application.Services;

/// <summary>
/// The user service class.
/// </summary>
internal sealed class UserService : IUserService
{
	/// <summary>
	/// Initializes an instance of <see cref="UserService"/> class.
	/// </summary>
	public UserService()
		=> User = string.Concat(Environment.MachineName, "\\", Environment.UserName);

	public string User { get; }
}
