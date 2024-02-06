namespace DomainName.Domain.Interfaces.Models.Base;

/// <summary>
/// The data model base interface.
/// </summary>
public interface IDataModelBase : IIdentityModel<Guid>, IConcurrencyModel, IAuditedModel, IModelBase
{ }
