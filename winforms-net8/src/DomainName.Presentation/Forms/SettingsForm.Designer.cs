namespace DomainName.Presentation.Forms;

partial class SettingsForm
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
		settingsViewModelBindingSource = new BindingSource(components);
		mainTableLayoutPanel = new TableLayoutPanel();
		settingsGroupBox = new GroupBox();
		settingsTableLayoutPanel = new TableLayoutPanel();
		saveButton = new Button();
		logLevelLabel = new Label();
		languageLabel = new Label();
		logLevelComboBox = new ComboBox();
		languageComboBox = new ComboBox();
		((System.ComponentModel.ISupportInitialize)settingsViewModelBindingSource).BeginInit();
		mainTableLayoutPanel.SuspendLayout();
		settingsGroupBox.SuspendLayout();
		settingsTableLayoutPanel.SuspendLayout();
		SuspendLayout();
		// 
		// settingsViewModelBindingSource
		// 
		settingsViewModelBindingSource.DataSource = typeof(Application.ViewModels.SettingsViewModel);
		// 
		// mainTableLayoutPanel
		// 
		mainTableLayoutPanel.ColumnCount = 3;
		mainTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
		mainTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
		mainTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
		mainTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
		mainTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
		mainTableLayoutPanel.Controls.Add(settingsGroupBox, 1, 1);
		mainTableLayoutPanel.Dock = DockStyle.Fill;
		mainTableLayoutPanel.Location = new Point(0, 0);
		mainTableLayoutPanel.Name = "mainTableLayoutPanel";
		mainTableLayoutPanel.RowCount = 3;
		mainTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
		mainTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
		mainTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
		mainTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
		mainTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
		mainTableLayoutPanel.Size = new Size(640, 360);
		mainTableLayoutPanel.TabIndex = 0;
		// 
		// settingsGroupBox
		// 
		settingsGroupBox.Controls.Add(settingsTableLayoutPanel);
		settingsGroupBox.Dock = DockStyle.Fill;
		settingsGroupBox.Location = new Point(23, 23);
		settingsGroupBox.Name = "settingsGroupBox";
		settingsGroupBox.Size = new Size(594, 314);
		settingsGroupBox.TabIndex = 0;
		settingsGroupBox.TabStop = false;
		settingsGroupBox.Text = "Settings";
		// 
		// settingsTableLayoutPanel
		// 
		settingsTableLayoutPanel.ColumnCount = 3;
		settingsTableLayoutPanel.ColumnStyles.Add(new ColumnStyle());
		settingsTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
		settingsTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
		settingsTableLayoutPanel.Controls.Add(saveButton, 2, 2);
		settingsTableLayoutPanel.Controls.Add(logLevelLabel, 0, 0);
		settingsTableLayoutPanel.Controls.Add(languageLabel, 0, 1);
		settingsTableLayoutPanel.Controls.Add(logLevelComboBox, 1, 0);
		settingsTableLayoutPanel.Controls.Add(languageComboBox, 1, 1);
		settingsTableLayoutPanel.Dock = DockStyle.Fill;
		settingsTableLayoutPanel.Location = new Point(3, 23);
		settingsTableLayoutPanel.Name = "settingsTableLayoutPanel";
		settingsTableLayoutPanel.RowCount = 3;
		settingsTableLayoutPanel.RowStyles.Add(new RowStyle());
		settingsTableLayoutPanel.RowStyles.Add(new RowStyle());
		settingsTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
		settingsTableLayoutPanel.Size = new Size(588, 288);
		settingsTableLayoutPanel.TabIndex = 0;
		// 
		// saveButton
		// 
		saveButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
		saveButton.DataBindings.Add(new Binding("Command", settingsViewModelBindingSource, "SaveCommand", true, DataSourceUpdateMode.OnPropertyChanged));
		saveButton.DataBindings.Add(new Binding("Visible", settingsViewModelBindingSource, "SaveButtonVisible", true, DataSourceUpdateMode.OnPropertyChanged));
		saveButton.Location = new Point(491, 256);
		saveButton.Name = "saveButton";
		saveButton.Size = new Size(94, 29);
		saveButton.TabIndex = 0;
		saveButton.Text = "Save";
		saveButton.UseVisualStyleBackColor = true;
		// 
		// logLevelLabel
		// 
		logLevelLabel.Anchor = AnchorStyles.Left;
		logLevelLabel.AutoSize = true;
		logLevelLabel.Location = new Point(3, 7);
		logLevelLabel.Name = "logLevelLabel";
		logLevelLabel.Size = new Size(68, 20);
		logLevelLabel.TabIndex = 1;
		logLevelLabel.Text = "LogLevel";
		// 
		// languageLabel
		// 
		languageLabel.Anchor = AnchorStyles.Left;
		languageLabel.AutoSize = true;
		languageLabel.Location = new Point(3, 41);
		languageLabel.Name = "languageLabel";
		languageLabel.Size = new Size(74, 20);
		languageLabel.TabIndex = 2;
		languageLabel.Text = "Language";
		// 
		// logLevelComboBox
		// 
		logLevelComboBox.Anchor = AnchorStyles.Left | AnchorStyles.Right;
		logLevelComboBox.FormattingEnabled = true;
		logLevelComboBox.Location = new Point(83, 3);
		logLevelComboBox.Name = "logLevelComboBox";
		logLevelComboBox.Size = new Size(248, 28);
		logLevelComboBox.TabIndex = 3;
		// 
		// languageComboBox
		// 
		languageComboBox.Anchor = AnchorStyles.Left | AnchorStyles.Right;
		languageComboBox.FormattingEnabled = true;
		languageComboBox.Location = new Point(83, 37);
		languageComboBox.Name = "languageComboBox";
		languageComboBox.Size = new Size(248, 28);
		languageComboBox.TabIndex = 4;
		// 
		// SettingsForm
		// 
		AutoScaleDimensions = new SizeF(8F, 20F);
		AutoScaleMode = AutoScaleMode.Font;
		ClientSize = new Size(640, 360);
		Controls.Add(mainTableLayoutPanel);
		Margin = new Padding(2);
		Name = "SettingsForm";
		Text = "SettingsForm";
		((System.ComponentModel.ISupportInitialize)settingsViewModelBindingSource).EndInit();
		mainTableLayoutPanel.ResumeLayout(false);
		settingsGroupBox.ResumeLayout(false);
		settingsTableLayoutPanel.ResumeLayout(false);
		settingsTableLayoutPanel.PerformLayout();
		ResumeLayout(false);
	}

	#endregion

	private BindingSource settingsViewModelBindingSource;
	private TableLayoutPanel mainTableLayoutPanel;
	private GroupBox settingsGroupBox;
	private TableLayoutPanel settingsTableLayoutPanel;
	private Button saveButton;
	private Label logLevelLabel;
	private Label languageLabel;
	private ComboBox logLevelComboBox;
	private ComboBox languageComboBox;
}