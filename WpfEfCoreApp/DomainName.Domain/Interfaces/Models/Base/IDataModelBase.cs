namespace DomainName.Domain.Interfaces.Models.Base;

/// <summary>
/// The data model base interface.
/// </summary>
public interface IDataModelBase
{
	/// <summary>
	/// The primary key of the table.
	/// </summary>
	Guid Id { get; }

	/// <summary>
	/// The current timestamp or row version.
	/// </summary>
	byte[] Timestamp { get; }

	/// <summary>
	/// The creator of the data row.
	/// </summary>
	string CreatedBy { get; set; }

	/// <summary>
	/// The last modifier of the data row.
	/// </summary>
	string? ModifiedBy { get; set; }
}
