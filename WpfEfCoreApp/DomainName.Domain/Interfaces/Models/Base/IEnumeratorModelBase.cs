namespace DomainName.Domain.Interfaces.Models.Base;

/// <inheritdoc/>
/// <remarks>
/// The key for <see cref="IIdentityModel{T}"/> is of type <see cref="int"/>.
/// </remarks>
public interface IEnumeratorModelBase : IEnumeratorModelBase<int>
{ }

/// <summary>
/// The enumerator model base interface.
/// </summary>
/// <inheritdoc/>
public interface IEnumeratorModelBase<T> : IIdentityModel<T>, IConcurrencyModel, IAuditedModel, IModelBase where T: IEquatable<T>
{
	/// <summary>
	/// The name of the enumerator.
	/// </summary>
	string Name { get; set; }

	/// <summary>
	/// The description of the enumerator.
	/// </summary>
	string Description { get; set; }
}
