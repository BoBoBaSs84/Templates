using DomainName.Domain.Models.Base;

namespace DomainName.Domain.Models;

/// <summary>
/// The example model class.
/// </summary>
public sealed class ExampleModel : DataModelBase
{
	/// <inheritdoc/>
	public string FirstName { get; set; } = default!;

	/// <inheritdoc/>
	public string LastName { get; set; } = default!;

	/// <inheritdoc/>
	public int Age { get; set; } = default!;
}
