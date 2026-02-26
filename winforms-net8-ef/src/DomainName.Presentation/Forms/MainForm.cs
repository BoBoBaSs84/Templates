using DomainName.Application.Abstractions.Application.Services;
using DomainName.Application.Abstractions.Presentation.Services;
using DomainName.Application.Events;
using DomainName.Application.ViewModels;
using DomainName.Presentation.Properties;

namespace DomainName.Presentation.Forms;

/// <summary>
/// The main form class.
/// </summary>
public partial class MainForm : Form
{
	private readonly IEventService _eventService;
	private readonly INavigationService _navigationService;
	private readonly MainViewModel _mainViewModel;

	/// <summary>
	/// Initializes a new instance of the <see cref="MainForm"/> class.
	/// </summary>
	/// <param name="eventService">The event service to publish and subscribe to events.</param>
	/// <param name="navigationService">The navigation service instance to use.</param>
	/// <param name="mainViewModel">The main view model instance to use.</param>
	public MainForm(IEventService eventService, INavigationService navigationService, MainViewModel mainViewModel)
	{
		InitializeComponent();
		_navigationService = navigationService;
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

		aboutToolStripMenuItem.Image = Resources.About.ToBitmap();
		exitToolStripMenuItem.Image = Resources.Exit.ToBitmap();
		settingsToolStripMenuItem.Image = Resources.Settings.ToBitmap();
	}

	private void RegisterEvents()
	{
		_navigationService.PropertyChanging += (s, e) => OnCurrentFormChanging();
		_navigationService.PropertyChanged += (s, e) => OnCurrentFormChanged();
		_eventService.Subscribe<ShowAboutEvent>(OnShowAbout);
		_eventService.Subscribe<ShowOpenFileEvent>(OnShowOpenFile);
		_eventService.Subscribe<ShowSaveFileEvent>(OnShowSaveFile);
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
		=> _navigationService.NavigateTo<AboutForm>();

	private void OnShowSaveFile(ShowSaveFileEvent @event)
	{
		using SaveFileDialog saveFileDialog = new()
		{
			Title = "Save File",
			Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*",
			DefaultExt = "txt",
			AddExtension = true,
			InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)
		};

		if (saveFileDialog.ShowDialog() == DialogResult.OK)
		{
			string filePath = saveFileDialog.FileName;
			_eventService.Publish(new SaveFileEvent(filePath, @event.FileContent));
		}
	}

	private void OnShowOpenFile(ShowOpenFileEvent @event)
	{

		using OpenFileDialog openFileDialog = new()
		{
			Title = "Open File",
			Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*",
			DefaultExt = "txt",
			AddExtension = true,
			InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)
		};
		if (openFileDialog.ShowDialog() == DialogResult.OK)
		{
			string filePath = openFileDialog.FileName;
			_eventService.Publish(new OpenFileEvent(filePath));
		}
	}

	private void OnShowSettings(ShowSettingsEvent @event)
		=> _navigationService.NavigateTo<SettingsForm>();
}
