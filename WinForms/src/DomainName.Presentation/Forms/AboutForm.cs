using DomainName.Application.ViewModels;

namespace DomainName.Presentation.Forms;

/// <summary>
/// The form for the about page.
/// </summary>
public partial class AboutForm : Form
{
	/// <summary>
	/// Initializes a new instance of the <see cref="AboutForm"/> class.
	/// </summary>
	/// <param name="viewModel">The view model instance to use.</param>
	public AboutForm(AboutViewModel viewModel)
	{
		InitializeComponent();

		TitleLabelValue.Text = viewModel.Model.Title;
		VersionLabelValue.Text = viewModel.Model.Version;
		CompanyLabelValue.Text = viewModel.Model.Company;
		CopyrightLabelValue.Text = viewModel.Model.Copyright;
		FrameworkLabelValue.Text = viewModel.Model.FrameworkName;
		RepositoryLabelValue.Text = viewModel.Model.Repository;
		DescriptionLabelValue.Text = viewModel.Model.Comments;
	}
}
