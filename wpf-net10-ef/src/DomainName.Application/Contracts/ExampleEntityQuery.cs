using DomainName.Application.Features;
using DomainName.Domain.Entities;

namespace DomainName.Application.Contracts;

/// <summary>
/// Represents a query for <see cref="ExampleEntity"/> entities.
/// </summary>
public sealed class ExampleEntityQuery : PagedQuery
{
	/// <summary>
	/// Filter by first name. If null, no filtering is applied.
	/// </summary>
	public string? FirstName { get; }

	/// <summary>
	/// Filter by last name. If null, no filtering is applied.
	/// </summary>
	public string? LastName { get; }

	/// <summary>
	/// Filter by age. If null, no filtering is applied.
	/// </summary>
	public int? Age { get; }
}
