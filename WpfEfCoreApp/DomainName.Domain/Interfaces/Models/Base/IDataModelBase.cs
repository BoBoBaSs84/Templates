namespace DomainName.Domain.Interfaces.Models.Base;

/// <inheritdoc/>
/// <remarks>
/// The key for <see cref="IIdentityModel{T}"/> is of type <see cref="Guid"/>.
/// </remarks>
public interface IDataModelBase : IDataModelBase<Guid>
{ }

/// <summary>
/// The data model base interface.
/// </summary>
/// <inheritdoc/>
public interface IDataModelBase<T> : IIdentityModel<T>, IConcurrencyModel, IAuditedModel, IModelBase where T : IEquatable<T>
{ }
