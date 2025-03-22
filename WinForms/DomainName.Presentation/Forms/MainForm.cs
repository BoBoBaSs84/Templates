using BB84.WinForms.Extensions;

using DomainName.Application.Interfaces.Presentation.Services;
using DomainName.Application.ViewModels;

using FormsApplication = System.Windows.Forms.Application;

namespace DomainName.Presentation.Forms;

/// <summary>
/// The main form class.
/// </summary>
public partial class MainForm : Form
{
	private readonly ICurrentUserService _currentUserService;
	private readonly INotificationService _notificationService;
	private readonly MainViewModel _mainViewModel;

	/// <summary>
	/// Initializes a new instance of the <see cref="MainForm"/> class.
	/// </summary>
	/// <param name="currentUserService">The current user service instance to use.</param>
	/// <param name="notificationService">The notification service instance to use.</param>
	/// <param name="mainViewModel">The main view model instance to use.</param>
	public MainForm(ICurrentUserService currentUserService, INotificationService notificationService, MainViewModel mainViewModel)
	{
		InitializeComponent();

		_currentUserService = currentUserService;
		_notificationService = notificationService;
		_mainViewModel = mainViewModel;

		NameTextBox.WithTextBinding(_mainViewModel.Model, nameof(_mainViewModel.Model.Name))
			.WithEnabledBinding(_mainViewModel, nameof(_mainViewModel.CanChangeName));

		AgeNumericUpDown.WithValueBinding(_mainViewModel.Model, nameof(_mainViewModel.Model.Age));

		MainStatusStrip.Items.Add(new ToolStripStatusLabel($"User: {_currentUserService.UserDomainName}\\{_currentUserService.UserName}"));
	}

	private void exitToolStripMenuItem_Click(object sender, EventArgs e)
	{
		_notificationService.SendInformation($"Bye, {_currentUserService.UserName}");
		FormsApplication.Exit();
	}
}
