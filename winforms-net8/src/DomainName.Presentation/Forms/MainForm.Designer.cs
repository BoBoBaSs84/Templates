namespace DomainName.Presentation.Forms;

partial class MainForm
{
	/// <summary>
	/// Required designer variable.
	/// </summary>
	private System.ComponentModel.IContainer components = null;

	/// <summary>
	/// Clean up any resources being used.
	/// </summary>
	/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
	protected override void Dispose(bool disposing)
	{
		if (disposing && (components != null))
		{
			components.Dispose();
		}
		base.Dispose(disposing);
	}

	#region Windows Form Designer generated code

	/// <summary>
	/// Required method for Designer support - do not modify
	/// the contents of this method with the code editor.
	/// </summary>
	private void InitializeComponent()
	{
		components = new System.ComponentModel.Container();
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
		menuStrip1 = new MenuStrip();
		fileToolStripMenuItem = new ToolStripMenuItem();
		newToolStripMenuItem = new ToolStripMenuItem();
		openToolStripMenuItem = new ToolStripMenuItem();
		toolStripSeparator = new ToolStripSeparator();
		saveToolStripMenuItem = new ToolStripMenuItem();
		saveAsToolStripMenuItem = new ToolStripMenuItem();
		toolStripSeparator1 = new ToolStripSeparator();
		printToolStripMenuItem = new ToolStripMenuItem();
		printPreviewToolStripMenuItem = new ToolStripMenuItem();
		toolStripSeparator2 = new ToolStripSeparator();
		exitToolStripMenuItem = new ToolStripMenuItem();
		mainViewModelBindingSource = new BindingSource(components);
		editToolStripMenuItem = new ToolStripMenuItem();
		undoToolStripMenuItem = new ToolStripMenuItem();
		redoToolStripMenuItem = new ToolStripMenuItem();
		toolStripSeparator3 = new ToolStripSeparator();
		cutToolStripMenuItem = new ToolStripMenuItem();
		copyToolStripMenuItem = new ToolStripMenuItem();
		pasteToolStripMenuItem = new ToolStripMenuItem();
		toolStripSeparator4 = new ToolStripSeparator();
		selectAllToolStripMenuItem = new ToolStripMenuItem();
		toolsToolStripMenuItem = new ToolStripMenuItem();
		customizeToolStripMenuItem = new ToolStripMenuItem();
		settingsToolStripMenuItem = new ToolStripMenuItem();
		languagesToolStripMenuItem = new ToolStripMenuItem();
		helpToolStripMenuItem = new ToolStripMenuItem();
		contentsToolStripMenuItem = new ToolStripMenuItem();
		indexToolStripMenuItem = new ToolStripMenuItem();
		searchToolStripMenuItem = new ToolStripMenuItem();
		toolStripSeparator5 = new ToolStripSeparator();
		AboutToolStripMenuItem = new ToolStripMenuItem();
		mainStatusStrip = new StatusStrip();
		mainStatusProgressBar = new ToolStripProgressBar();
		mainToolStripStatusLabel = new ToolStripStatusLabel();
		mainStatusStripLabel = new ToolStripStatusLabel();
		mainPanel = new Panel();
		menuStrip1.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)mainViewModelBindingSource).BeginInit();
		mainStatusStrip.SuspendLayout();
		SuspendLayout();
		// 
		// menuStrip1
		// 
		menuStrip1.ImageScalingSize = new Size(24, 24);
		menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, editToolStripMenuItem, toolsToolStripMenuItem, helpToolStripMenuItem });
		menuStrip1.Location = new Point(0, 0);
		menuStrip1.Name = "menuStrip1";
		menuStrip1.Size = new Size(1258, 33);
		menuStrip1.TabIndex = 0;
		menuStrip1.Text = "menuStrip1";
		// 
		// fileToolStripMenuItem
		// 
		fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { newToolStripMenuItem, openToolStripMenuItem, toolStripSeparator, saveToolStripMenuItem, saveAsToolStripMenuItem, toolStripSeparator1, printToolStripMenuItem, printPreviewToolStripMenuItem, toolStripSeparator2, exitToolStripMenuItem });
		fileToolStripMenuItem.Name = "fileToolStripMenuItem";
		fileToolStripMenuItem.Size = new Size(54, 29);
		fileToolStripMenuItem.Text = "&File";
		// 
		// newToolStripMenuItem
		// 
		newToolStripMenuItem.Image = (Image)resources.GetObject("newToolStripMenuItem.Image");
		newToolStripMenuItem.ImageTransparentColor = Color.Magenta;
		newToolStripMenuItem.Name = "newToolStripMenuItem";
		newToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.N;
		newToolStripMenuItem.Size = new Size(223, 34);
		newToolStripMenuItem.Text = "&New";
		// 
		// openToolStripMenuItem
		// 
		openToolStripMenuItem.Image = (Image)resources.GetObject("openToolStripMenuItem.Image");
		openToolStripMenuItem.ImageTransparentColor = Color.Magenta;
		openToolStripMenuItem.Name = "openToolStripMenuItem";
		openToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.O;
		openToolStripMenuItem.Size = new Size(223, 34);
		openToolStripMenuItem.Text = "&Open";
		// 
		// toolStripSeparator
		// 
		toolStripSeparator.Name = "toolStripSeparator";
		toolStripSeparator.Size = new Size(220, 6);
		// 
		// saveToolStripMenuItem
		// 
		saveToolStripMenuItem.Image = (Image)resources.GetObject("saveToolStripMenuItem.Image");
		saveToolStripMenuItem.ImageTransparentColor = Color.Magenta;
		saveToolStripMenuItem.Name = "saveToolStripMenuItem";
		saveToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.S;
		saveToolStripMenuItem.Size = new Size(223, 34);
		saveToolStripMenuItem.Text = "&Save";
		// 
		// saveAsToolStripMenuItem
		// 
		saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
		saveAsToolStripMenuItem.Size = new Size(223, 34);
		saveAsToolStripMenuItem.Text = "Save &As";
		// 
		// toolStripSeparator1
		// 
		toolStripSeparator1.Name = "toolStripSeparator1";
		toolStripSeparator1.Size = new Size(220, 6);
		// 
		// printToolStripMenuItem
		// 
		printToolStripMenuItem.Image = (Image)resources.GetObject("printToolStripMenuItem.Image");
		printToolStripMenuItem.ImageTransparentColor = Color.Magenta;
		printToolStripMenuItem.Name = "printToolStripMenuItem";
		printToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.P;
		printToolStripMenuItem.Size = new Size(223, 34);
		printToolStripMenuItem.Text = "&Print";
		// 
		// printPreviewToolStripMenuItem
		// 
		printPreviewToolStripMenuItem.Image = (Image)resources.GetObject("printPreviewToolStripMenuItem.Image");
		printPreviewToolStripMenuItem.ImageTransparentColor = Color.Magenta;
		printPreviewToolStripMenuItem.Name = "printPreviewToolStripMenuItem";
		printPreviewToolStripMenuItem.Size = new Size(223, 34);
		printPreviewToolStripMenuItem.Text = "Print Pre&view";
		// 
		// toolStripSeparator2
		// 
		toolStripSeparator2.Name = "toolStripSeparator2";
		toolStripSeparator2.Size = new Size(220, 6);
		// 
		// exitToolStripMenuItem
		// 
		exitToolStripMenuItem.DataBindings.Add(new Binding("Command", mainViewModelBindingSource, "ExitApplicationCommand", true));
		exitToolStripMenuItem.Name = "exitToolStripMenuItem";
		exitToolStripMenuItem.Size = new Size(223, 34);
		exitToolStripMenuItem.Text = "E&xit";
		// 
		// mainViewModelBindingSource
		// 
		mainViewModelBindingSource.DataSource = typeof(Application.ViewModels.MainViewModel);
		// 
		// editToolStripMenuItem
		// 
		editToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { undoToolStripMenuItem, redoToolStripMenuItem, toolStripSeparator3, cutToolStripMenuItem, copyToolStripMenuItem, pasteToolStripMenuItem, toolStripSeparator4, selectAllToolStripMenuItem });
		editToolStripMenuItem.Name = "editToolStripMenuItem";
		editToolStripMenuItem.Size = new Size(58, 29);
		editToolStripMenuItem.Text = "&Edit";
		// 
		// undoToolStripMenuItem
		// 
		undoToolStripMenuItem.Name = "undoToolStripMenuItem";
		undoToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.Z;
		undoToolStripMenuItem.Size = new Size(219, 34);
		undoToolStripMenuItem.Text = "&Undo";
		// 
		// redoToolStripMenuItem
		// 
		redoToolStripMenuItem.Name = "redoToolStripMenuItem";
		redoToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.Y;
		redoToolStripMenuItem.Size = new Size(219, 34);
		redoToolStripMenuItem.Text = "&Redo";
		// 
		// toolStripSeparator3
		// 
		toolStripSeparator3.Name = "toolStripSeparator3";
		toolStripSeparator3.Size = new Size(216, 6);
		// 
		// cutToolStripMenuItem
		// 
		cutToolStripMenuItem.Image = (Image)resources.GetObject("cutToolStripMenuItem.Image");
		cutToolStripMenuItem.ImageTransparentColor = Color.Magenta;
		cutToolStripMenuItem.Name = "cutToolStripMenuItem";
		cutToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.X;
		cutToolStripMenuItem.Size = new Size(219, 34);
		cutToolStripMenuItem.Text = "Cu&t";
		// 
		// copyToolStripMenuItem
		// 
		copyToolStripMenuItem.Image = (Image)resources.GetObject("copyToolStripMenuItem.Image");
		copyToolStripMenuItem.ImageTransparentColor = Color.Magenta;
		copyToolStripMenuItem.Name = "copyToolStripMenuItem";
		copyToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.C;
		copyToolStripMenuItem.Size = new Size(219, 34);
		copyToolStripMenuItem.Text = "&Copy";
		// 
		// pasteToolStripMenuItem
		// 
		pasteToolStripMenuItem.Image = (Image)resources.GetObject("pasteToolStripMenuItem.Image");
		pasteToolStripMenuItem.ImageTransparentColor = Color.Magenta;
		pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
		pasteToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.V;
		pasteToolStripMenuItem.Size = new Size(219, 34);
		pasteToolStripMenuItem.Text = "&Paste";
		// 
		// toolStripSeparator4
		// 
		toolStripSeparator4.Name = "toolStripSeparator4";
		toolStripSeparator4.Size = new Size(216, 6);
		// 
		// selectAllToolStripMenuItem
		// 
		selectAllToolStripMenuItem.Name = "selectAllToolStripMenuItem";
		selectAllToolStripMenuItem.Size = new Size(219, 34);
		selectAllToolStripMenuItem.Text = "Select &All";
		// 
		// toolsToolStripMenuItem
		// 
		toolsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { customizeToolStripMenuItem, settingsToolStripMenuItem, languagesToolStripMenuItem });
		toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
		toolsToolStripMenuItem.Size = new Size(69, 29);
		toolsToolStripMenuItem.Text = "&Tools";
		// 
		// customizeToolStripMenuItem
		// 
		customizeToolStripMenuItem.Name = "customizeToolStripMenuItem";
		customizeToolStripMenuItem.Size = new Size(270, 34);
		customizeToolStripMenuItem.Text = "&Customize";
		// 
		// settingsToolStripMenuItem
		// 
		settingsToolStripMenuItem.DataBindings.Add(new Binding("Command", mainViewModelBindingSource, "ShowSettingsCommand", true));
		settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
		settingsToolStripMenuItem.Size = new Size(270, 34);
		settingsToolStripMenuItem.Text = "&Settings";
		// 
		// languagesToolStripMenuItem
		// 
		languagesToolStripMenuItem.Name = "languagesToolStripMenuItem";
		languagesToolStripMenuItem.Size = new Size(270, 34);
		languagesToolStripMenuItem.Text = "&Languages";
		// 
		// helpToolStripMenuItem
		// 
		helpToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { contentsToolStripMenuItem, indexToolStripMenuItem, searchToolStripMenuItem, toolStripSeparator5, AboutToolStripMenuItem });
		helpToolStripMenuItem.Name = "helpToolStripMenuItem";
		helpToolStripMenuItem.Size = new Size(65, 29);
		helpToolStripMenuItem.Text = "&Help";
		// 
		// contentsToolStripMenuItem
		// 
		contentsToolStripMenuItem.Name = "contentsToolStripMenuItem";
		contentsToolStripMenuItem.Size = new Size(185, 34);
		contentsToolStripMenuItem.Text = "&Contents";
		// 
		// indexToolStripMenuItem
		// 
		indexToolStripMenuItem.Name = "indexToolStripMenuItem";
		indexToolStripMenuItem.Size = new Size(185, 34);
		indexToolStripMenuItem.Text = "&Index";
		// 
		// searchToolStripMenuItem
		// 
		searchToolStripMenuItem.Name = "searchToolStripMenuItem";
		searchToolStripMenuItem.Size = new Size(185, 34);
		searchToolStripMenuItem.Text = "&Search";
		// 
		// toolStripSeparator5
		// 
		toolStripSeparator5.Name = "toolStripSeparator5";
		toolStripSeparator5.Size = new Size(182, 6);
		// 
		// AboutToolStripMenuItem
		// 
		AboutToolStripMenuItem.DataBindings.Add(new Binding("Command", mainViewModelBindingSource, "ShowAboutCommand", true));
		AboutToolStripMenuItem.Name = "AboutToolStripMenuItem";
		AboutToolStripMenuItem.Size = new Size(185, 34);
		AboutToolStripMenuItem.Text = "&About...";
		// 
		// mainStatusStrip
		// 
		mainStatusStrip.ImageScalingSize = new Size(24, 24);
		mainStatusStrip.Items.AddRange(new ToolStripItem[] { mainStatusProgressBar, mainToolStripStatusLabel, mainStatusStripLabel });
		mainStatusStrip.Location = new Point(0, 712);
		mainStatusStrip.Name = "mainStatusStrip";
		mainStatusStrip.Size = new Size(1258, 32);
		mainStatusStrip.TabIndex = 2;
		mainStatusStrip.Text = "statusStrip1";
		// 
		// mainStatusProgressBar
		// 
		mainStatusProgressBar.DataBindings.Add(new Binding("Value", mainViewModelBindingSource, "ProgressBarValue", true, DataSourceUpdateMode.OnPropertyChanged));
		mainStatusProgressBar.DataBindings.Add(new Binding("Maximum", mainViewModelBindingSource, "ProgressBarMaximum", true, DataSourceUpdateMode.OnPropertyChanged));
		mainStatusProgressBar.DataBindings.Add(new Binding("Minimum", mainViewModelBindingSource, "ProgressBarMinimum", true, DataSourceUpdateMode.OnPropertyChanged));
		mainStatusProgressBar.DataBindings.Add(new Binding("Visible", mainViewModelBindingSource, "ProgressBarVisible", true, DataSourceUpdateMode.OnPropertyChanged));
		mainStatusProgressBar.Name = "mainStatusProgressBar";
		mainStatusProgressBar.Size = new Size(200, 24);
		// 
		// mainToolStripStatusLabel
		// 
		mainToolStripStatusLabel.Name = "mainToolStripStatusLabel";
		mainToolStripStatusLabel.Size = new Size(0, 25);
		// 
		// mainStatusStripLabel
		// 
		mainStatusStripLabel.DataBindings.Add(new Binding("Text", mainViewModelBindingSource, "StatusText", true, DataSourceUpdateMode.OnPropertyChanged));
		mainStatusStripLabel.Name = "mainStatusStripLabel";
		mainStatusStripLabel.Size = new Size(100, 25);
		mainStatusStripLabel.Text = "[StatusText]";
		// 
		// mainPanel
		// 
		mainPanel.Dock = DockStyle.Fill;
		mainPanel.Location = new Point(0, 33);
		mainPanel.Margin = new Padding(2);
		mainPanel.Name = "mainPanel";
		mainPanel.Size = new Size(1258, 679);
		mainPanel.TabIndex = 3;
		// 
		// MainForm
		// 
		AutoScaleDimensions = new SizeF(10F, 25F);
		AutoScaleMode = AutoScaleMode.Font;
		ClientSize = new Size(1258, 744);
		Controls.Add(mainPanel);
		Controls.Add(mainStatusStrip);
		Controls.Add(menuStrip1);
		MainMenuStrip = menuStrip1;
		Margin = new Padding(2);
		Name = "MainForm";
		Text = "MainForm";
		menuStrip1.ResumeLayout(false);
		menuStrip1.PerformLayout();
		((System.ComponentModel.ISupportInitialize)mainViewModelBindingSource).EndInit();
		mainStatusStrip.ResumeLayout(false);
		mainStatusStrip.PerformLayout();
		ResumeLayout(false);
		PerformLayout();
	}

	#endregion

	private MenuStrip menuStrip1;
	private ToolStripMenuItem fileToolStripMenuItem;
	private ToolStripMenuItem newToolStripMenuItem;
	private ToolStripMenuItem openToolStripMenuItem;
	private ToolStripSeparator toolStripSeparator;
	private ToolStripMenuItem saveToolStripMenuItem;
	private ToolStripMenuItem saveAsToolStripMenuItem;
	private ToolStripSeparator toolStripSeparator1;
	private ToolStripMenuItem printToolStripMenuItem;
	private ToolStripMenuItem printPreviewToolStripMenuItem;
	private ToolStripSeparator toolStripSeparator2;
	private ToolStripMenuItem exitToolStripMenuItem;
	private ToolStripMenuItem editToolStripMenuItem;
	private ToolStripMenuItem undoToolStripMenuItem;
	private ToolStripMenuItem redoToolStripMenuItem;
	private ToolStripSeparator toolStripSeparator3;
	private ToolStripMenuItem cutToolStripMenuItem;
	private ToolStripMenuItem copyToolStripMenuItem;
	private ToolStripMenuItem pasteToolStripMenuItem;
	private ToolStripSeparator toolStripSeparator4;
	private ToolStripMenuItem selectAllToolStripMenuItem;
	private ToolStripMenuItem toolsToolStripMenuItem;
	private ToolStripMenuItem customizeToolStripMenuItem;
	private ToolStripMenuItem settingsToolStripMenuItem;
	private ToolStripMenuItem helpToolStripMenuItem;
	private ToolStripMenuItem contentsToolStripMenuItem;
	private ToolStripMenuItem indexToolStripMenuItem;
	private ToolStripMenuItem searchToolStripMenuItem;
	private ToolStripSeparator toolStripSeparator5;
	private ToolStripMenuItem AboutToolStripMenuItem;
	private StatusStrip mainStatusStrip;
	private Panel mainPanel;
	private ToolStripProgressBar mainStatusProgressBar;
	private ToolStripStatusLabel mainToolStripStatusLabel;
	private ToolStripMenuItem languagesToolStripMenuItem;
	private ToolStripStatusLabel mainStatusStripLabel;
	private BindingSource mainViewModelBindingSource;
}
