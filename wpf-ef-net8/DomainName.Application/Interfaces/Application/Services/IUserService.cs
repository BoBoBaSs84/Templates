namespace DomainName.Application.Interfaces.Application.Services;

/// <summary>
/// The user service interface.
/// </summary>
public interface IUserService
{
	/// <summary>
	/// The current user's domain.
	/// </summary>
	string Domain { get; }

	/// <summary>
	/// The current user's machine.
	/// </summary>
	string Machine { get; }

	/// <summary>
	/// The current application user.
	/// </summary>
	string User { get; }
}
