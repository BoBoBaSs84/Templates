using BB84.EntityFrameworkCore.Models;

using DomainName.Domain.Interfaces.Models.Base;

namespace DomainName.Domain.Models.Base;

/// <summary>
/// The data model base class.
/// </summary>
public abstract class DataModelBase : AuditedModel, IDataModelBase
{ }
