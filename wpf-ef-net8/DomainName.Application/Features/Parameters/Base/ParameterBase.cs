namespace DomainName.Application.Features.Parameters.Base;

/// <summary>
/// The parameter base class.
/// </summary>
public abstract class ParameterBase
{
	private const int MaxPageSize = 100;
	private int _pageSize = 20;

	/// <summary>
	/// The page number property.
	/// </summary>
	public int PageNumber { get; set; } = 1;

	/// <summary>
	/// The page size property.
	/// </summary>
	/// <remarks>
	/// The current maximum is 100.
	/// </remarks>
	public int PageSize
	{
		get => _pageSize;
		set => _pageSize = value > MaxPageSize ? MaxPageSize : value;
	}
}
