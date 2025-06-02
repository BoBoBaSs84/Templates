using DomainName.Application.Interfaces.Application.Services;

namespace DomainName.Application.Services;

/// <summary>
/// The user service class.
/// </summary>
internal sealed class UserService : IUserService
{
	public string Domain => $"{Environment.UserDomainName}";
	public string Machine => $"{Environment.MachineName}";
	public string User => $"{Environment.UserName}";
}
