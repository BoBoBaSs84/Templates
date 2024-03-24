using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

using DomainName.Domain.Interfaces.Models.Base;

namespace DomainName.Domain.Models.Base;

/// <summary>
/// The enumerator model base class.
/// </summary>
public abstract class EnumeratorModelBase : ModelBase, IEnumeratorModelBase
{
	private int _id = default!;
	private byte[] _timestamp = default!;
	private string _createdBy = string.Empty;
	private string? _modifiedBy;
	private string _name = string.Empty;
	private string _description = string.Empty;

	/// <inheritdoc/>
	[Key, Column(Order = 1)]
	[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
	public int Id
	{
		get => _id;
		private set => SetProperty(ref _id, value);
	}

	/// <inheritdoc/>
	[Timestamp, Column(Order = 2)]
	[DatabaseGenerated(DatabaseGeneratedOption.Computed)]
	public byte[] Timestamp
	{
		get => _timestamp;
		private set => SetProperty(ref _timestamp, value);
	}

	/// <inheritdoc/>
	[MaxLength(128), Column(Order = 3)]
	public string CreatedBy
	{
		get => _createdBy;
		set => SetProperty(ref _createdBy, value);
	}

	/// <inheritdoc/>
	[MaxLength(128), Column(Order = 4)]
	public string? ModifiedBy
	{
		get => _modifiedBy;
		set => SetProperty(ref _modifiedBy, value);
	}

	/// <inheritdoc/>
	[MaxLength(128), Column(Order = 5)]
	public string Name
	{
		get => _name;
		set => SetProperty(ref _name, value);
	}

	/// <inheritdoc/>
	[MaxLength(1024), Column(Order = 6)]
	public string Description
	{
		get => _description;
		set => SetProperty(ref _description, value);
	}
}
