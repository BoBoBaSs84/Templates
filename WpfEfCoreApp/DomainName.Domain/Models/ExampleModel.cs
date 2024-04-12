using DomainName.Domain.Interfaces.Models;
using DomainName.Domain.Models.Base;

namespace DomainName.Domain.Models;

/// <summary>
/// The example model class.
/// </summary>
public sealed class ExampleModel : DataModelBase, IExampleModel
{
	/// <inheritdoc/>
	public string FirstName { get; set; }

	/// <inheritdoc/>
	public string LastName { get; set; }

	/// <inheritdoc/>
	public int Age { get; set; }
}
