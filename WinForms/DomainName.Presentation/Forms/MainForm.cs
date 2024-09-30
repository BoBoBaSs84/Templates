using DomainName.Application.Interfaces.Presentation.Services;

using FormsApplication = System.Windows.Forms.Application;

namespace DomainName.Presentation.Forms;

/// <summary>
/// The main form class.
/// </summary>
public partial class MainForm : Form
{
	private readonly INotificationService _notificationService;

	/// <summary>
	/// Initializes a new instance of the <see cref="MainForm"/> class.
	/// </summary>
	/// <param name="notificationService">The notification service instance to use.</param>
	public MainForm(INotificationService notificationService)
	{
		_notificationService = notificationService;
		InitializeComponent();
	}

	private void exitToolStripMenuItem_Click(object sender, EventArgs e)
	{
		_notificationService.SendInformation("Bye!");
		FormsApplication.Exit();
	}
}
