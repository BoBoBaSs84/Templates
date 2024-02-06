using DomainName.Application.ViewModels.Base;
using DomainName.Domain.Interfaces.Models;

namespace DomainName.Application.ViewModels;

/// <summary>
/// The about view model class.
/// </summary>
/// <param name="model">The model instance to use.</param>
public sealed class AboutViewModel(IAboutModel model) : ViewModelBase
{
	/// <summary>
	/// The model instance to use.
	/// </summary>
	public IAboutModel Model => model;
}
