using DomainName.Application.Abstractions.Application.Services;
using DomainName.Application.Abstractions.Presentation.Services;
using DomainName.Application.ViewModels;
using DomainName.Domain.Events.Presentation;

using Microsoft.Extensions.DependencyInjection;

using WinFormsApp = System.Windows.Forms.Application;

namespace DomainName.Presentation.Forms;

/// <summary>
/// The main form class.
/// </summary>
public partial class MainForm : Form
{
	private readonly INavigationService _navigationService;
	private readonly IServiceProvider _serviceProvider;
	private readonly IEventService _eventService;
	private bool _statusChanged;

	/// <summary>
	/// Initializes a new instance of the <see cref="MainForm"/> class.
	/// </summary>
	/// <param name="navigationService">The navigation service instance to use.</param>
	/// <param name="serviceProvider">The service provider instance to use.</param>
	/// <param name="eventService">The event service instance to use.</param>
	/// <param name="mainViewModel">The main view model instance to use.</param>
	public MainForm(
		INavigationService navigationService,
		IServiceProvider serviceProvider,
		IEventService eventService,
		MainViewModel mainViewModel
		)
	{
		InitializeComponent();

		Text = $"{mainViewModel.ApplicationName} - {mainViewModel.EnvironmentName} - {mainViewModel.CurrentUser}";

		_navigationService = navigationService;
		_serviceProvider = serviceProvider;
		_eventService = eventService;

		_navigationService.PropertyChanging += (s, e) => OnCurrentFormChanging();
		_navigationService.PropertyChanged += (s, e) => OnCurrentFormChanged();

		_eventService.Subscribe<StatusChangedEvent>(OnStatusChanged);
		_eventService.Subscribe<ProgressChangedEvent>(OnProgressChanged);
	}

	private void OnProgressChanged(ProgressChangedEvent @event)
	{
		mainToolStripProgressBar.Value = @event.Value;
		mainToolStripProgressBar.Minimum = @event.Minimum;
		mainToolStripProgressBar.Maximum = @event.Maximum;
	}

	private void OnStatusChanged(StatusChangedEvent @event)
	{
		mainToolStripStatusLabel.Text = @event.Text;
		Task.Run(() =>
		{
			_statusChanged = true;
			Thread.Sleep(2000);
			if (_statusChanged)
				mainToolStripStatusLabel.Text = string.Empty;
			_statusChanged = false;
		}).ConfigureAwait(true);
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

	private void ExitToolStripMenuItem_Click(object sender, EventArgs e) => WinFormsApp.Exit();

	private void FirstToolStripMenuItem_Click(object sender, EventArgs e) => _navigationService.NavigateTo<FirstForm>();

	private void SecondToolStripMenuItem_Click(object sender, EventArgs e) => _navigationService.NavigateTo<SecondForm>();

	private void ThirdToolStripMenuItem_Click(object sender, EventArgs e) => _navigationService.NavigateTo<ThirdForm>();

	private void AboutToolStripMenuItem_Click(object sender, EventArgs e)
	{
		AboutForm aboutForm = _serviceProvider.GetRequiredService<AboutForm>();
		aboutForm.ShowDialog(this);
	}
}
