using BB84.SourceGenerators.Attributes;

using DomainName.Application.Abstractions.Application.Services;
using DomainName.Application.Abstractions.Services;
using DomainName.Application.Enumerators;
using DomainName.Application.Events;
using DomainName.Application.ViewModels.Base;

using Microsoft.Extensions.Hosting;

using RESX = DomainName.Application.Properties.Resources;

namespace DomainName.Application.ViewModels;

/// <summary>
/// The main view model class.
/// </summary>
[GenerateNotifications]
public sealed partial class MainViewModel : ViewModelBase
{
	[ExcludeFromNotification] private readonly IEventService _eventService;
	[ExcludeFromNotification] private readonly INotificationService _notificationService;
	[ExcludeFromNotification] private readonly SynchronizationContext? _synchronizationContext;

	/// <summary>
	/// Initializes a new instance of the <see cref="MainViewModel"/> class.
	/// </summary>
	/// <param name="eventService">The event service for subscribing to application events.</param>
	/// <param name="hostEnvironment">The host environment instance to use.</param>
	/// <param name="navigationService">The navigation service instance to use.</param>
	/// <param name="notificationService">The notification service instance to use.</param>
	public MainViewModel(IEventService eventService, IHostEnvironment hostEnvironment, INavigationService navigationService, INotificationService notificationService)
	{
		_eventService = eventService;
		_notificationService = notificationService;
		_synchronizationContext = SynchronizationContext.Current;
		ApplicationTitle = $"{hostEnvironment.ApplicationName} - {hostEnvironment.EnvironmentName}";
		ApplicationStatus = string.Empty;
		ProgressBarMaximum = 100;

		NavigationService = navigationService;

		_eventService.Subscribe<DelayedStatusChangedEvent>(OnStatusChanged);
		_eventService.Subscribe<ProgressChangedEvent>(OnProgressChanged);
	}

	/// <summary>
	/// Gets or sets the title of the application.
	/// </summary>
	public partial string ApplicationTitle { get; private set; }

	/// <summary>
	/// Gets or sets the current status of the application.
	/// </summary>
	public partial string ApplicationStatus { get; private set; }

	/// <summary>
	/// Gets or sets the value of the progress bar.
	/// </summary>
	public partial int ProgressBarValue { get; set; }

	/// <summary>
	/// Gets or sets a value indicating whether the progress bar is visible.
	/// </summary>
	public partial bool ProgressBarVisible { get; set; }

	/// <summary>
	/// Gets or sets the maximum value of the progress bar.
	/// </summary>
	public partial int ProgressBarMaximum { get; set; }

	/// <summary>
	/// Gets or sets the minimum value of the progress bar.
	/// </summary>
	public partial int ProgressBarMinimum { get; set; }

	/// <summary>
	/// Gets the navigation service instance.
	/// </summary>
	public INavigationService NavigationService { get; }

	[ActionCommand]
	private void ShowAbout()
		=> NavigationService.NavigateTo<AboutViewModel>();

	[ActionCommand]
	private void ShowSettings()
		=> NavigationService.NavigateTo<SettingsViewModel>();

	[ActionCommand]
	private void ExitApplication()
	{
		NotificationResult result = _notificationService
			.ShowQuestion(RESX.MainViewModel_Notification_QuitApplication);

		if (result == NotificationResult.Yes)
			_eventService.Publish(new ExitRequestedEvent());
	}

	private void OnStatusChanged(DelayedStatusChangedEvent @event)
	{
		if (_synchronizationContext is not null)
			_synchronizationContext.Post(_ => ChangeStatus(@event), null);
		else
			ChangeStatus(@event);
	}

	private void ChangeStatus(DelayedStatusChangedEvent @event)
	{
		ApplicationStatus = @event.Text;

		if (@event.AutoClear)
		{
			_ = Task.Delay(@event.Duration)
				.ContinueWith(_ => ApplicationStatus = string.Empty);
		}
	}

	private void OnProgressChanged(ProgressChangedEvent @event)
	{
		if (_synchronizationContext is not null)
			_synchronizationContext.Post(_ => ChangeProgress(@event), null);
		else
			ChangeProgress(@event);
	}

	private void ChangeProgress(ProgressChangedEvent @event)
	{
		ProgressBarMaximum = @event.Maximum;
		ProgressBarMinimum = @event.Minimum;
		ProgressBarValue = @event.Value;
		ProgressBarVisible = @event.Value is > 0 and < 100;
	}
}
