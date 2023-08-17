using FormsApplication = System.Windows.Forms.Application;

namespace DomainName.Presentation.Forms;

public partial class MainForm : Form
{
	public MainForm()
	{
		InitializeComponent();
	}

	private void exitToolStripMenuItem_Click(object sender, EventArgs e)
		=> FormsApplication.Exit();
}
