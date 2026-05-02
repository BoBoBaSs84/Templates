namespace DomainName.Application.Abstractions.Presentation.Services;

/// <summary>
/// Represents a service contract that provides information about the
/// current user, such as their name, domain, and machine name.
/// </summary>
public interface IUserService
{
	/// <summary>
	/// Gets the name of the current user.
	/// </summary>
	string Name { get; }

	/// <summary>
	/// Gets the domain name of the current user.
	/// </summary>
	string Domain { get; }

	/// <summary>
	/// Gets the name of the machine on which the current user is logged in.
	/// </summary>
	string Machine { get; }
}
