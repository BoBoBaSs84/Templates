using BB84.SourceGenerators.Attributes;

using DomainName.Application.Abstractions.Application.Services;
using DomainName.Application.Abstractions.Application.ViewModels;
using DomainName.Application.ViewModels.Base;

namespace DomainName.Application.Services;

/// <summary>
/// The navigation service class.
/// </summary>
/// <param name="viewModelFactory">The view model factory to use.</param>
[GenerateNotifications]
internal sealed partial class NavigationService(Func<Type, ViewModelBase> viewModelFactory) : INavigationService
{
	public partial ViewModelBase CurrentView { get; private set; }

	public void NavigateTo<T>() where T : ViewModelBase, INavigatable
		=> CurrentView = viewModelFactory.Invoke(typeof(T));
}
