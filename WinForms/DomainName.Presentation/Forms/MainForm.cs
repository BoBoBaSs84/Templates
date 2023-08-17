namespace DomainName.Presentation.Forms;

public partial class MainForm : Form
{
	public MainForm()
	{
		InitializeComponent();
	}

	private void exitToolStripMenuItem_Click(object sender, EventArgs e)
		=> System.Windows.Forms.Application.Exit();
}
