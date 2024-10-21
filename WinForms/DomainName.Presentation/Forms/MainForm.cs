using DomainName.Application.Interfaces.Presentation.Services;

using FormsApplication = System.Windows.Forms.Application;

namespace DomainName.Presentation.Forms;

/// <summary>
/// The main form class.
/// </summary>
public partial class MainForm : Form
{
	private readonly ICurrentUserService _currentUserService;
	private readonly INotificationService _notificationService;

	/// <summary>
	/// Initializes a new instance of the <see cref="MainForm"/> class.
	/// </summary>
	/// <param name="currentUserService">The current user service instance to use.</param>
	/// <param name="notificationService">The notification service instance to use.</param>
	public MainForm(ICurrentUserService currentUserService, INotificationService notificationService)
	{
		InitializeComponent();

		_currentUserService = currentUserService;
		_notificationService = notificationService;
	}

	private void exitToolStripMenuItem_Click(object sender, EventArgs e)
	{
		_notificationService.SendInformation($"Bye, {_currentUserService.UserName}");
		FormsApplication.Exit();
	}
}
