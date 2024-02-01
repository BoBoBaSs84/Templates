namespace DomainName.Application.Interfaces.Application.Services;

/// <summary>
/// The user service interface.
/// </summary>
public interface IUserService
{
	/// <summary>
	/// The current application user.
	/// </summary>
	string User { get; }
}
