using BB84.Notifications;

using DomainName.Application.Interfaces.Application.Services;
using DomainName.Application.ViewModels.Base;

namespace DomainName.Application.Services;

/// <summary>
/// The navigation service class.
/// </summary>
/// <param name="viewModelFactory">The view model factory to use.</param>
internal sealed class NavigationService(Func<Type, BaseViewModel> viewModelFactory) : NotificationObject, INavigationService
{
	private BaseViewModel _currentView = default!;

	public BaseViewModel CurrentView
	{
		get => _currentView;
		private set => SetProperty(ref _currentView, value);
	}

	public void NavigateTo<T>() where T : BaseViewModel
		=> CurrentView = viewModelFactory.Invoke(typeof(T));
}
