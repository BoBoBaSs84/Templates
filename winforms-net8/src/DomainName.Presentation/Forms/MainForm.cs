using DomainName.Application.Abstractions.Application.Services;
using DomainName.Application.Abstractions.Presentation.Services;
using DomainName.Application.Events;
using DomainName.Application.ViewModels;
using DomainName.Presentation.Properties;

using Microsoft.Extensions.DependencyInjection;

namespace DomainName.Presentation.Forms;

/// <summary>
/// The main form class.
/// </summary>
public partial class MainForm : Form
{
	private readonly IEventService _eventService;
	private readonly INavigationService _navigationService;
	private readonly IServiceProvider _serviceProvider;
	private readonly MainViewModel _mainViewModel;

	/// <summary>
	/// Initializes a new instance of the <see cref="MainForm"/> class.
	/// </summary>
	/// <param name="eventService">The event service to publish and subscribe to events.</param>
	/// <param name="navigationService">The navigation service instance to use.</param>
	/// <param name="serviceProvider">The service provider instance to use.</param>
	/// <param name="mainViewModel">The main view model instance to use.</param>
	public MainForm(IEventService eventService, INavigationService navigationService, IServiceProvider serviceProvider, MainViewModel mainViewModel)
	{
		InitializeComponent();
		_navigationService = navigationService;
		_serviceProvider = serviceProvider;
		_eventService = eventService;
		_mainViewModel = mainViewModel;

		SetupForm();
		RegisterEvents();
	}

	/// <inheritdoc/>
	protected override void OnLoad(EventArgs e)
	{
		base.OnLoad(e);
		mainViewModelBindingSource.DataSource = _mainViewModel;
	}

	private void SetupForm()
	{
		Text = _mainViewModel.ApplicationTitle;
		Icon = Resources.Application;
	}

	private void RegisterEvents()
	{
		_navigationService.PropertyChanging += (s, e) => OnCurrentFormChanging();
		_navigationService.PropertyChanged += (s, e) => OnCurrentFormChanged();
		_eventService.Subscribe<ShowAboutEvent>(OnShowAbout);
		_eventService.Subscribe<ShowSettingsEvent>(OnShowSettings);
	}

	private void OnCurrentFormChanged()
	{
		if (_navigationService.CurrentForm is not null)
			mainPanel.Controls.Add(_navigationService.CurrentForm);
	}

	private void OnCurrentFormChanging()
	{
		if (_navigationService.CurrentForm is not null)
			mainPanel.Controls.Remove(_navigationService.CurrentForm);
	}

	private void OnShowAbout(ShowAboutEvent @event)
	{
		AboutForm aboutForm = _serviceProvider.GetRequiredService<AboutForm>();
		aboutForm.ShowDialog(this);
	}

	private void OnShowSettings(ShowSettingsEvent @event)
		=> _navigationService.NavigateTo<SettingsForm>();
}
