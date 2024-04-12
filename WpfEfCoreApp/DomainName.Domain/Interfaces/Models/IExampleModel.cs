using DomainName.Domain.Interfaces.Models.Base;

namespace DomainName.Domain.Interfaces.Models;

/// <summary>
/// The example model interface.
/// </summary>
public interface IExampleModel : IDataModelBase
{
	/// <summary>
	/// The first name.
	/// </summary>
	string FirstName { get; set; }

	/// <summary>
	/// The last name.
	/// </summary>
	string LastName { get; set; }

	/// <summary>
	/// The age.
	/// </summary>
	int Age { get; set; }
}
