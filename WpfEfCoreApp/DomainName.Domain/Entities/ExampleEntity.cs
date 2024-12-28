using DomainName.Domain.Entities.Base;

namespace DomainName.Domain.Entities;

/// <summary>
/// The example entity class.
/// </summary>
public sealed class ExampleEntity : EntityBase
{
	/// <inheritdoc/>
	public string FirstName { get; set; } = default!;

	/// <inheritdoc/>
	public string LastName { get; set; } = default!;

	/// <inheritdoc/>
	public int Age { get; set; } = default!;
}
