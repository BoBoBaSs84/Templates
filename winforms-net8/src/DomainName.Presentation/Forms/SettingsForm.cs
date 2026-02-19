using BB84.WinForms.Extensions;

using DomainName.Application.Abstractions.Application.Services;
using DomainName.Application.Abstractions.Presentation.Services;
using DomainName.Application.Events;
using DomainName.Application.ViewModels;
using DomainName.Presentation.Properties;

namespace DomainName.Presentation.Forms;

/// <summary>
/// Represents the settings form of the application.
/// </summary>
public partial class SettingsForm : Form
{
	private readonly IEventService _eventService;
	private readonly INotificationService _notificationService;
	private readonly SettingsViewModel _viewModel;

	/// <summary>
	/// Initializes a new instance of the <see cref="SettingsForm"/> class.
	/// </summary>
	/// <param name="eventService">The event service used to subscribe to settings change events.</param>
	/// <param name="notificationService">The notification service used to display messages to the user.</param>
	/// <param name="viewModel">The view model containing the settings data and logic.</param>
	public SettingsForm(IEventService eventService, INotificationService notificationService, SettingsViewModel viewModel)
	{
		_eventService = eventService;
		_notificationService = notificationService;
		_viewModel = viewModel;

		InitializeComponent();
		SetupForm();
		RegisterEvents();
	}

	/// <inheritdoc/>
	protected override void OnLoad(EventArgs e)
	{
		base.OnLoad(e);
		settingsViewModelBindingSource.DataSource = _viewModel;

		logLevelComboBox.WithEnumeratorBinding(_viewModel.LogLevel)
			.WithSelectedValueBinding(_viewModel, nameof(_viewModel.LogLevel));
		languageComboBox.WithEnumeratorBinding(_viewModel.Language)
			.WithSelectedValueBinding(_viewModel, nameof(_viewModel.Language));
	}

	private void SetupForm()
	{
		settingsGroupBox.Text = Resources.Form_Settings_Settings;
		logLevelLabel.Text = Resources.Form_Settings_LogLevel;
		languageLabel.Text = Resources.Form_Settings_Language;
		saveButton.Text = Resources.Form_Settings_Save;
	}

	private void RegisterEvents()
		=> _eventService.Subscribe<SettingsChangedEvent>(OnSettingsChanged);

	private void OnSettingsChanged(SettingsChangedEvent @event)
	{
		DialogResult result = _notificationService
			.ShowQuestion(Resources.Notification_Question_SettingsChanged);

		if (result is DialogResult.Yes)
			_eventService.Publish(new RestartApplicationEvent());
	}
}
