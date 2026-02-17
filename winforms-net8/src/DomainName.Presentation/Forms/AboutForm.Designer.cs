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
		versionLabelValue = new Label();
		companyLabelValue = new Label();
		copyrightLabelValue = new Label();
		frameworkLabelValue = new Label();
		repositoryLabelValue = new Label();
		DescriptionLabel = new Label();
		descriptionLabelValue = new Label();
		aboutViewModelBindingSource = new BindingSource(components);
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
		TableLayoutPanel.Size = new Size(800, 450);
		TableLayoutPanel.TabIndex = 0;
		// 
		// FrameworkLabel
		// 
		FrameworkLabel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		FrameworkLabel.AutoSize = true;
		FrameworkLabel.Location = new Point(349, 147);
		FrameworkLabel.Margin = new Padding(3);
		FrameworkLabel.Name = "FrameworkLabel";
		FrameworkLabel.Size = new Size(104, 25);
		FrameworkLabel.TabIndex = 27;
		FrameworkLabel.Text = "Framework:";
		// 
		// CopyrightLabel
		// 
		CopyrightLabel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		CopyrightLabel.AutoSize = true;
		CopyrightLabel.Location = new Point(358, 116);
		CopyrightLabel.Margin = new Padding(3);
		CopyrightLabel.Name = "CopyrightLabel";
		CopyrightLabel.Size = new Size(95, 25);
		CopyrightLabel.TabIndex = 22;
		CopyrightLabel.Text = "Copyright:";
		// 
		// CompanyLabel
		// 
		CompanyLabel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		CompanyLabel.AutoSize = true;
		CompanyLabel.Location = new Point(360, 85);
		CompanyLabel.Margin = new Padding(3);
		CompanyLabel.Name = "CompanyLabel";
		CompanyLabel.Size = new Size(93, 25);
		CompanyLabel.TabIndex = 17;
		CompanyLabel.Text = "Company:";
		// 
		// VersionLabel
		// 
		VersionLabel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		VersionLabel.AutoSize = true;
		VersionLabel.Location = new Point(379, 54);
		VersionLabel.Margin = new Padding(3);
		VersionLabel.Name = "VersionLabel";
		VersionLabel.Size = new Size(74, 25);
		VersionLabel.TabIndex = 12;
		VersionLabel.Text = "Version:";
		// 
		// TitelLabel
		// 
		TitelLabel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		TitelLabel.AutoSize = true;
		TitelLabel.Location = new Point(405, 23);
		TitelLabel.Margin = new Padding(3);
		TitelLabel.Name = "TitelLabel";
		TitelLabel.Size = new Size(48, 25);
		TitelLabel.TabIndex = 0;
		TitelLabel.Text = "Title:";
		// 
		// RepositoryLabel
		// 
		RepositoryLabel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		RepositoryLabel.AutoSize = true;
		RepositoryLabel.Location = new Point(352, 178);
		RepositoryLabel.Margin = new Padding(3);
		RepositoryLabel.Name = "RepositoryLabel";
		RepositoryLabel.Size = new Size(101, 25);
		RepositoryLabel.TabIndex = 28;
		RepositoryLabel.Text = "Repository:";
		// 
		// titleLabelValue
		// 
		titleLabelValue.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
		titleLabelValue.AutoSize = true;
		titleLabelValue.DataBindings.Add(new Binding("Text", aboutViewModelBindingSource, "Title", true, DataSourceUpdateMode.Never));
		titleLabelValue.Location = new Point(459, 23);
		titleLabelValue.Margin = new Padding(3);
		titleLabelValue.Name = "titleLabelValue";
		titleLabelValue.Size = new Size(318, 25);
		titleLabelValue.TabIndex = 29;
		titleLabelValue.Text = "TitleLabelValue";
		// 
		// versionLabelValue
		// 
		versionLabelValue.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
		versionLabelValue.AutoSize = true;
		versionLabelValue.DataBindings.Add(new Binding("Text", aboutViewModelBindingSource, "Version", true, DataSourceUpdateMode.Never));
		versionLabelValue.Location = new Point(459, 54);
		versionLabelValue.Margin = new Padding(3);
		versionLabelValue.Name = "versionLabelValue";
		versionLabelValue.Size = new Size(318, 25);
		versionLabelValue.TabIndex = 30;
		versionLabelValue.Text = "VersionLabelValue";
		// 
		// companyLabelValue
		// 
		companyLabelValue.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
		companyLabelValue.AutoSize = true;
		companyLabelValue.DataBindings.Add(new Binding("Text", aboutViewModelBindingSource, "Company", true, DataSourceUpdateMode.Never));
		companyLabelValue.Location = new Point(459, 85);
		companyLabelValue.Margin = new Padding(3);
		companyLabelValue.Name = "companyLabelValue";
		companyLabelValue.Size = new Size(318, 25);
		companyLabelValue.TabIndex = 31;
		companyLabelValue.Text = "CompanyLabelValue";
		// 
		// copyrightLabelValue
		// 
		copyrightLabelValue.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
		copyrightLabelValue.AutoSize = true;
		copyrightLabelValue.DataBindings.Add(new Binding("Text", aboutViewModelBindingSource, "Copyright", true, DataSourceUpdateMode.Never));
		copyrightLabelValue.Location = new Point(459, 116);
		copyrightLabelValue.Margin = new Padding(3);
		copyrightLabelValue.Name = "copyrightLabelValue";
		copyrightLabelValue.Size = new Size(318, 25);
		copyrightLabelValue.TabIndex = 32;
		copyrightLabelValue.Text = "CopyrightLabelValue";
		// 
		// frameworkLabelValue
		// 
		frameworkLabelValue.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
		frameworkLabelValue.AutoSize = true;
		frameworkLabelValue.DataBindings.Add(new Binding("Text", aboutViewModelBindingSource, "FrameworkName", true, DataSourceUpdateMode.Never));
		frameworkLabelValue.Location = new Point(459, 147);
		frameworkLabelValue.Margin = new Padding(3);
		frameworkLabelValue.Name = "frameworkLabelValue";
		frameworkLabelValue.Size = new Size(318, 25);
		frameworkLabelValue.TabIndex = 33;
		frameworkLabelValue.Text = "FrameworkLabelValue";
		// 
		// repositoryLabelValue
		// 
		repositoryLabelValue.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
		repositoryLabelValue.AutoSize = true;
		repositoryLabelValue.DataBindings.Add(new Binding("Text", aboutViewModelBindingSource, "Repository", true, DataSourceUpdateMode.Never));
		repositoryLabelValue.Location = new Point(459, 178);
		repositoryLabelValue.Margin = new Padding(3);
		repositoryLabelValue.Name = "repositoryLabelValue";
		repositoryLabelValue.Size = new Size(318, 25);
		repositoryLabelValue.TabIndex = 34;
		repositoryLabelValue.Text = "RepositoryLabelValue";
		// 
		// DescriptionLabel
		// 
		DescriptionLabel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		DescriptionLabel.AutoSize = true;
		DescriptionLabel.Location = new Point(347, 209);
		DescriptionLabel.Margin = new Padding(3);
		DescriptionLabel.Name = "DescriptionLabel";
		DescriptionLabel.Size = new Size(106, 25);
		DescriptionLabel.TabIndex = 35;
		DescriptionLabel.Text = "Description:";
		// 
		// descriptionLabelValue
		// 
		descriptionLabelValue.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
		descriptionLabelValue.AutoSize = true;
		descriptionLabelValue.DataBindings.Add(new Binding("Text", aboutViewModelBindingSource, "Comments", true, DataSourceUpdateMode.Never));
		descriptionLabelValue.Location = new Point(459, 209);
		descriptionLabelValue.Margin = new Padding(3);
		descriptionLabelValue.Name = "descriptionLabelValue";
		descriptionLabelValue.Size = new Size(318, 25);
		descriptionLabelValue.TabIndex = 36;
		descriptionLabelValue.Text = "DescriptionLabelValue";
		// 
		// aboutViewModelBindingSource
		// 
		aboutViewModelBindingSource.DataSource = typeof(Application.ViewModels.AboutViewModel);
		// 
		// AboutForm
		// 
		AutoScaleDimensions = new SizeF(10F, 25F);
		AutoScaleMode = AutoScaleMode.Font;
		ClientSize = new Size(800, 450);
		Controls.Add(TableLayoutPanel);
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