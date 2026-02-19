namespace DomainName.Presentation.Forms;

partial class AboutForm
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
		TableLayoutPanel = new TableLayoutPanel();
		FrameworkLabel = new Label();
		CopyrightLabel = new Label();
		CompanyLabel = new Label();
		VersionLabel = new Label();
		TitelLabel = new Label();
		RepositoryLabel = new Label();
		titleLabelValue = new Label();
		aboutViewModelBindingSource = new BindingSource(components);
		versionLabelValue = new Label();
		companyLabelValue = new Label();
		copyrightLabelValue = new Label();
		frameworkLabelValue = new Label();
		repositoryLabelValue = new Label();
		DescriptionLabel = new Label();
		descriptionLabelValue = new Label();
		TableLayoutPanel.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)aboutViewModelBindingSource).BeginInit();
		SuspendLayout();
		// 
		// TableLayoutPanel
		// 
		TableLayoutPanel.ColumnCount = 5;
		TableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
		TableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
		TableLayoutPanel.ColumnStyles.Add(new ColumnStyle());
		TableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
		TableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
		TableLayoutPanel.Controls.Add(FrameworkLabel, 2, 5);
		TableLayoutPanel.Controls.Add(CopyrightLabel, 2, 4);
		TableLayoutPanel.Controls.Add(CompanyLabel, 2, 3);
		TableLayoutPanel.Controls.Add(VersionLabel, 2, 2);
		TableLayoutPanel.Controls.Add(TitelLabel, 2, 1);
		TableLayoutPanel.Controls.Add(RepositoryLabel, 2, 6);
		TableLayoutPanel.Controls.Add(titleLabelValue, 3, 1);
		TableLayoutPanel.Controls.Add(versionLabelValue, 3, 2);
		TableLayoutPanel.Controls.Add(companyLabelValue, 3, 3);
		TableLayoutPanel.Controls.Add(copyrightLabelValue, 3, 4);
		TableLayoutPanel.Controls.Add(frameworkLabelValue, 3, 5);
		TableLayoutPanel.Controls.Add(repositoryLabelValue, 3, 6);
		TableLayoutPanel.Controls.Add(DescriptionLabel, 2, 7);
		TableLayoutPanel.Controls.Add(descriptionLabelValue, 3, 7);
		TableLayoutPanel.Dock = DockStyle.Fill;
		TableLayoutPanel.Location = new Point(0, 0);
		TableLayoutPanel.Margin = new Padding(2, 2, 2, 2);
		TableLayoutPanel.Name = "TableLayoutPanel";
		TableLayoutPanel.RowCount = 10;
		TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
		TableLayoutPanel.RowStyles.Add(new RowStyle());
		TableLayoutPanel.RowStyles.Add(new RowStyle());
		TableLayoutPanel.RowStyles.Add(new RowStyle());
		TableLayoutPanel.RowStyles.Add(new RowStyle());
		TableLayoutPanel.RowStyles.Add(new RowStyle());
		TableLayoutPanel.RowStyles.Add(new RowStyle());
		TableLayoutPanel.RowStyles.Add(new RowStyle());
		TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
		TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
		TableLayoutPanel.Size = new Size(640, 360);
		TableLayoutPanel.TabIndex = 0;
		// 
		// FrameworkLabel
		// 
		FrameworkLabel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		FrameworkLabel.AutoSize = true;
		FrameworkLabel.Location = new Point(279, 118);
		FrameworkLabel.Margin = new Padding(2, 2, 2, 2);
		FrameworkLabel.Name = "FrameworkLabel";
		FrameworkLabel.Size = new Size(85, 20);
		FrameworkLabel.TabIndex = 27;
		FrameworkLabel.Text = "Framework:";
		// 
		// CopyrightLabel
		// 
		CopyrightLabel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		CopyrightLabel.AutoSize = true;
		CopyrightLabel.Location = new Point(287, 94);
		CopyrightLabel.Margin = new Padding(2, 2, 2, 2);
		CopyrightLabel.Name = "CopyrightLabel";
		CopyrightLabel.Size = new Size(77, 20);
		CopyrightLabel.TabIndex = 22;
		CopyrightLabel.Text = "Copyright:";
		// 
		// CompanyLabel
		// 
		CompanyLabel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		CompanyLabel.AutoSize = true;
		CompanyLabel.Location = new Point(289, 70);
		CompanyLabel.Margin = new Padding(2, 2, 2, 2);
		CompanyLabel.Name = "CompanyLabel";
		CompanyLabel.Size = new Size(75, 20);
		CompanyLabel.TabIndex = 17;
		CompanyLabel.Text = "Company:";
		// 
		// VersionLabel
		// 
		VersionLabel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		VersionLabel.AutoSize = true;
		VersionLabel.Location = new Point(304, 46);
		VersionLabel.Margin = new Padding(2, 2, 2, 2);
		VersionLabel.Name = "VersionLabel";
		VersionLabel.Size = new Size(60, 20);
		VersionLabel.TabIndex = 12;
		VersionLabel.Text = "Version:";
		// 
		// TitelLabel
		// 
		TitelLabel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		TitelLabel.AutoSize = true;
		TitelLabel.Location = new Point(323, 22);
		TitelLabel.Margin = new Padding(2, 2, 2, 2);
		TitelLabel.Name = "TitelLabel";
		TitelLabel.Size = new Size(41, 20);
		TitelLabel.TabIndex = 0;
		TitelLabel.Text = "Title:";
		// 
		// RepositoryLabel
		// 
		RepositoryLabel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		RepositoryLabel.AutoSize = true;
		RepositoryLabel.Location = new Point(281, 142);
		RepositoryLabel.Margin = new Padding(2, 2, 2, 2);
		RepositoryLabel.Name = "RepositoryLabel";
		RepositoryLabel.Size = new Size(83, 20);
		RepositoryLabel.TabIndex = 28;
		RepositoryLabel.Text = "Repository:";
		// 
		// titleLabelValue
		// 
		titleLabelValue.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
		titleLabelValue.AutoSize = true;
		titleLabelValue.DataBindings.Add(new Binding("Text", aboutViewModelBindingSource, "Title", true, DataSourceUpdateMode.Never));
		titleLabelValue.Location = new Point(368, 22);
		titleLabelValue.Margin = new Padding(2, 2, 2, 2);
		titleLabelValue.Name = "titleLabelValue";
		titleLabelValue.Size = new Size(250, 20);
		titleLabelValue.TabIndex = 29;
		titleLabelValue.Text = "TitleLabelValue";
		// 
		// aboutViewModelBindingSource
		// 
		aboutViewModelBindingSource.DataSource = typeof(Application.ViewModels.AboutViewModel);
		// 
		// versionLabelValue
		// 
		versionLabelValue.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
		versionLabelValue.AutoSize = true;
		versionLabelValue.DataBindings.Add(new Binding("Text", aboutViewModelBindingSource, "Version", true, DataSourceUpdateMode.Never));
		versionLabelValue.Location = new Point(368, 46);
		versionLabelValue.Margin = new Padding(2, 2, 2, 2);
		versionLabelValue.Name = "versionLabelValue";
		versionLabelValue.Size = new Size(250, 20);
		versionLabelValue.TabIndex = 30;
		versionLabelValue.Text = "VersionLabelValue";
		// 
		// companyLabelValue
		// 
		companyLabelValue.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
		companyLabelValue.AutoSize = true;
		companyLabelValue.DataBindings.Add(new Binding("Text", aboutViewModelBindingSource, "Company", true, DataSourceUpdateMode.Never));
		companyLabelValue.Location = new Point(368, 70);
		companyLabelValue.Margin = new Padding(2, 2, 2, 2);
		companyLabelValue.Name = "companyLabelValue";
		companyLabelValue.Size = new Size(250, 20);
		companyLabelValue.TabIndex = 31;
		companyLabelValue.Text = "CompanyLabelValue";
		// 
		// copyrightLabelValue
		// 
		copyrightLabelValue.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
		copyrightLabelValue.AutoSize = true;
		copyrightLabelValue.DataBindings.Add(new Binding("Text", aboutViewModelBindingSource, "Copyright", true, DataSourceUpdateMode.Never));
		copyrightLabelValue.Location = new Point(368, 94);
		copyrightLabelValue.Margin = new Padding(2, 2, 2, 2);
		copyrightLabelValue.Name = "copyrightLabelValue";
		copyrightLabelValue.Size = new Size(250, 20);
		copyrightLabelValue.TabIndex = 32;
		copyrightLabelValue.Text = "CopyrightLabelValue";
		// 
		// frameworkLabelValue
		// 
		frameworkLabelValue.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
		frameworkLabelValue.AutoSize = true;
		frameworkLabelValue.DataBindings.Add(new Binding("Text", aboutViewModelBindingSource, "FrameworkName", true, DataSourceUpdateMode.Never));
		frameworkLabelValue.Location = new Point(368, 118);
		frameworkLabelValue.Margin = new Padding(2, 2, 2, 2);
		frameworkLabelValue.Name = "frameworkLabelValue";
		frameworkLabelValue.Size = new Size(250, 20);
		frameworkLabelValue.TabIndex = 33;
		frameworkLabelValue.Text = "FrameworkLabelValue";
		// 
		// repositoryLabelValue
		// 
		repositoryLabelValue.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
		repositoryLabelValue.AutoSize = true;
		repositoryLabelValue.DataBindings.Add(new Binding("Text", aboutViewModelBindingSource, "Repository", true, DataSourceUpdateMode.Never));
		repositoryLabelValue.Location = new Point(368, 142);
		repositoryLabelValue.Margin = new Padding(2, 2, 2, 2);
		repositoryLabelValue.Name = "repositoryLabelValue";
		repositoryLabelValue.Size = new Size(250, 20);
		repositoryLabelValue.TabIndex = 34;
		repositoryLabelValue.Text = "RepositoryLabelValue";
		// 
		// DescriptionLabel
		// 
		DescriptionLabel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		DescriptionLabel.AutoSize = true;
		DescriptionLabel.Location = new Point(276, 166);
		DescriptionLabel.Margin = new Padding(2, 2, 2, 2);
		DescriptionLabel.Name = "DescriptionLabel";
		DescriptionLabel.Size = new Size(88, 20);
		DescriptionLabel.TabIndex = 35;
		DescriptionLabel.Text = "Description:";
		// 
		// descriptionLabelValue
		// 
		descriptionLabelValue.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
		descriptionLabelValue.AutoSize = true;
		descriptionLabelValue.DataBindings.Add(new Binding("Text", aboutViewModelBindingSource, "Comments", true, DataSourceUpdateMode.Never));
		descriptionLabelValue.Location = new Point(368, 166);
		descriptionLabelValue.Margin = new Padding(2, 2, 2, 2);
		descriptionLabelValue.Name = "descriptionLabelValue";
		descriptionLabelValue.Size = new Size(250, 20);
		descriptionLabelValue.TabIndex = 36;
		descriptionLabelValue.Text = "DescriptionLabelValue";
		// 
		// AboutForm
		// 
		AutoScaleDimensions = new SizeF(8F, 20F);
		AutoScaleMode = AutoScaleMode.Font;
		ClientSize = new Size(640, 360);
		Controls.Add(TableLayoutPanel);
		Margin = new Padding(2, 2, 2, 2);
		Name = "AboutForm";
		Text = "AboutForm";
		TableLayoutPanel.ResumeLayout(false);
		TableLayoutPanel.PerformLayout();
		((System.ComponentModel.ISupportInitialize)aboutViewModelBindingSource).EndInit();
		ResumeLayout(false);
	}

	#endregion

	private TableLayoutPanel TableLayoutPanel;
	private Label TitelLabel;
	private Label FrameworkLabel;
	private Label CopyrightLabel;
	private Label CompanyLabel;
	private Label VersionLabel;
	private Label RepositoryLabel;
	private Label titleLabelValue;
	private Label versionLabelValue;
	private Label companyLabelValue;
	private Label copyrightLabelValue;
	private Label frameworkLabelValue;
	private Label repositoryLabelValue;
	private Label DescriptionLabel;
	private Label descriptionLabelValue;
	private BindingSource aboutViewModelBindingSource;
}