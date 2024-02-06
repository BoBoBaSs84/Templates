namespace DomainName.Domain.Interfaces.Models.Base;

/// <summary>
/// The audited model interface.
/// </summary>
public interface IAuditedModel
{
	/// <summary>
	/// The creator of the data row.
	/// </summary>
	string CreatedBy { get; set; }

	/// <summary>
	/// The last modifier of the data row.
	/// </summary>
	string? ModifiedBy { get; set; }
}
