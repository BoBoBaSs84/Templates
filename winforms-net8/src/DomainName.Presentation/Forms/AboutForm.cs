using DomainName.Application.ViewModels;
using DomainName.Presentation.Properties;

namespace DomainName.Presentation.Forms;

/// <summary>
/// The form for the about page.
/// </summary>
public partial class AboutForm : Form
{
	private readonly AboutViewModel _aboutViewModel;

	/// <summary>
	/// Initializes a new instance of the <see cref="AboutForm"/> class.
	/// </summary>
	/// <param name="viewModel">The view model instance to use.</param>
	public AboutForm(AboutViewModel viewModel)
	{
		InitializeComponent();

		_aboutViewModel = viewModel;

		SetupForm();
	}

	/// <inheritdoc/>
	protected override void OnLoad(EventArgs e)
	{
		base.OnLoad(e);
		aboutViewModelBindingSource.DataSource = _aboutViewModel;
	}

	private void SetupForm()
	{
		Text = "About ...";
		Icon = Resources.About;
	}
}
