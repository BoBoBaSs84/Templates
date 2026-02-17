using DomainName.Application.ViewModels;
using DomainName.Presentation.Properties;

namespace DomainName.Presentation.Forms;

public partial class SettingsForm : Form
{
	private readonly SettingsViewModel _viewModel;

	/// <summary>
	/// Initializes a new instance of the <see cref="SettingsForm"/> class.
	/// </summary>
	public SettingsForm(SettingsViewModel viewModel)
	{
		InitializeComponent();

		_viewModel = viewModel;

		SetupForm();
	}

	protected override void OnLoad(EventArgs e)
	{
		base.OnLoad(e);
		settingsViewModelBindingSource.DataSource = _viewModel;
	}

	private void SetupForm()
	{
		Text = "Settings ...";
		Icon = Resources.Settings;
	}
}
