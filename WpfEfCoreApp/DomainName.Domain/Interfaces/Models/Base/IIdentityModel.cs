namespace DomainName.Domain.Interfaces.Models.Base;

/// <summary>
/// The identity model interface.
/// </summary>
/// <typeparam name="T">The type of the primary key.</typeparam>
public interface IIdentityModel<T> where T : IEquatable<T>
{
	/// <summary>
	/// The primary key of the database table.
	/// </summary>
	T Id { get; }
}
