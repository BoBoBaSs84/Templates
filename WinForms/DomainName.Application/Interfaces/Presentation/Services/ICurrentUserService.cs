namespace DomainName.Application.Interfaces.Presentation.Services;

/// <summary>
/// The interface for the current user service.
/// </summary>
public interface ICurrentUserService
{
	/// <summary>
	/// The current user name.
	/// </summary>
	string UserName { get; }

	/// <summary>
	/// The current user domain name.
	/// </summary>
	string UserDomainName {  get; }

	/// <summary>
	/// The current user machine name.
	/// </summary>
	string MachineName {  get; }
}
