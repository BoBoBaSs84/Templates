using DomainName.Domain.Interfaces.Models.Base;

namespace DomainName.Domain.Interfaces.Models;

/// <summary>
/// The about model interface.
/// </summary>
public interface IAboutModel : IModelBase
{
	/// <summary>
	/// The title of the application.
	/// </summary>
	string? Title { get; }

	/// <summary>
	/// The version of the application.
	/// </summary>
	string? Version { get; }

	/// <summary>
	/// The comments of the application.
	/// </summary>
	string? Comments { get; }

	/// <summary>
	/// The company of the application.
	/// </summary>
	string? Company { get; }

	/// <summary>
	/// The copyright of the application.
	/// </summary>
	string? Copyright { get; }
}
