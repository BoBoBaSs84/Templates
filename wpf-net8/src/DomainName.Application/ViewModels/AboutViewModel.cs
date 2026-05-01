using DomainName.Application.Abstractions.Application.ViewModels;
using DomainName.Application.ViewModels.Base;
using DomainName.Domain.Models;

namespace DomainName.Application.ViewModels;

/// <summary>
/// The about view model class.
/// </summary>
/// <param name="model">The model instance to use.</param>
public sealed class AboutViewModel(AboutModel model) : ViewModelBase, INavigatable
{
	/// <summary>
	/// The model instance to use.
	/// </summary>
	public AboutModel Model => model;
}
