using DomainName.Application.Interfaces.Presentation.Services;
using DomainName.Application.ViewModels;

using FormsApplication = System.Windows.Forms.Application;

namespace DomainName.Presentation.Forms;

/// <summary>
/// The main form class.
/// </summary>
public partial class MainForm : Form
{
	private readonly INavigationService _navigationService;
	private readonly MainViewModel _mainViewModel;

	/// <summary>
	/// Initializes a new instance of the <see cref="MainForm"/> class.
	/// </summary>
	/// <param name="navigationService">The navigation service instance to use.</param>
	/// <param name="mainViewModel">The main view model instance to use.</param>
	public MainForm(INavigationService navigationService, MainViewModel mainViewModel)
	{
		InitializeComponent();

		_navigationService = navigationService;
		_mainViewModel = mainViewModel;

		_navigationService.PropertyChanging += (s, e) => OnCurrentFormChanging();
		_navigationService.PropertyChanged += (s, e) => OnCurrentFormChanged();

		MainStatusStrip.Items.Add(new ToolStripStatusLabel($"User: {_mainViewModel.User}"));
	}

	private void OnCurrentFormChanged()
	{
		if (_navigationService.CurrentForm is not null)
			MainPanel.Controls.Add(_navigationService.CurrentForm);
	}

	private void OnCurrentFormChanging()
	{
		if (_navigationService.CurrentForm is not null)
			MainPanel.Controls.Remove(_navigationService.CurrentForm);
	}

	private void ExitToolStripMenuItem_Click(object sender, EventArgs e) => FormsApplication.Exit();

	private void FirstToolStripMenuItem_Click(object sender, EventArgs e) => _navigationService.NavigateTo<FirstForm>();

	private void SecondToolStripMenuItem_Click(object sender, EventArgs e) => _navigationService.NavigateTo<SecondForm>();

	private void ThirdToolStripMenuItem_Click(object sender, EventArgs e) => _navigationService.NavigateTo<ThirdForm>();
}
