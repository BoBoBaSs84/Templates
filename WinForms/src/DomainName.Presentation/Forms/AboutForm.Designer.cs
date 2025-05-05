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
		TableLayoutPanel = new TableLayoutPanel();
		FrameworkLabel = new Label();
		CopyrightLabel = new Label();
		CompanyLabel = new Label();
		VersionLabel = new Label();
		TitelLabel = new Label();
		RepositoryLabel = new Label();
		TitleLabelValue = new Label();
		VersionLabelValue = new Label();
		CompanyLabelValue = new Label();
		CopyrightLabelValue = new Label();
		FrameworkLabelValue = new Label();
		RepositoryLabelValue = new Label();
		DescriptionLabel = new Label();
		DescriptionLabelValue = new Label();
		TableLayoutPanel.SuspendLayout();
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
		TableLayoutPanel.Controls.Add(TitleLabelValue, 3, 1);
		TableLayoutPanel.Controls.Add(VersionLabelValue, 3, 2);
		TableLayoutPanel.Controls.Add(CompanyLabelValue, 3, 3);
		TableLayoutPanel.Controls.Add(CopyrightLabelValue, 3, 4);
		TableLayoutPanel.Controls.Add(FrameworkLabelValue, 3, 5);
		TableLayoutPanel.Controls.Add(RepositoryLabelValue, 3, 6);
		TableLayoutPanel.Controls.Add(DescriptionLabel, 2, 7);
		TableLayoutPanel.Controls.Add(DescriptionLabelValue, 3, 7);
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
		// TitleLabelValue
		// 
		TitleLabelValue.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
		TitleLabelValue.AutoSize = true;
		TitleLabelValue.Location = new Point(459, 23);
		TitleLabelValue.Margin = new Padding(3);
		TitleLabelValue.Name = "TitleLabelValue";
		TitleLabelValue.Size = new Size(318, 25);
		TitleLabelValue.TabIndex = 29;
		TitleLabelValue.Text = "TitleLabelValue";
		// 
		// VersionLabelValue
		// 
		VersionLabelValue.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
		VersionLabelValue.AutoSize = true;
		VersionLabelValue.Location = new Point(459, 54);
		VersionLabelValue.Margin = new Padding(3);
		VersionLabelValue.Name = "VersionLabelValue";
		VersionLabelValue.Size = new Size(318, 25);
		VersionLabelValue.TabIndex = 30;
		VersionLabelValue.Text = "VersionLabelValue";
		// 
		// CompanyLabelValue
		// 
		CompanyLabelValue.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
		CompanyLabelValue.AutoSize = true;
		CompanyLabelValue.Location = new Point(459, 85);
		CompanyLabelValue.Margin = new Padding(3);
		CompanyLabelValue.Name = "CompanyLabelValue";
		CompanyLabelValue.Size = new Size(318, 25);
		CompanyLabelValue.TabIndex = 31;
		CompanyLabelValue.Text = "CompanyLabelValue";
		// 
		// CopyrightLabelValue
		// 
		CopyrightLabelValue.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
		CopyrightLabelValue.AutoSize = true;
		CopyrightLabelValue.Location = new Point(459, 116);
		CopyrightLabelValue.Margin = new Padding(3);
		CopyrightLabelValue.Name = "CopyrightLabelValue";
		CopyrightLabelValue.Size = new Size(318, 25);
		CopyrightLabelValue.TabIndex = 32;
		CopyrightLabelValue.Text = "CopyrightLabelValue";
		// 
		// FrameworkLabelValue
		// 
		FrameworkLabelValue.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
		FrameworkLabelValue.AutoSize = true;
		FrameworkLabelValue.Location = new Point(459, 147);
		FrameworkLabelValue.Margin = new Padding(3);
		FrameworkLabelValue.Name = "FrameworkLabelValue";
		FrameworkLabelValue.Size = new Size(318, 25);
		FrameworkLabelValue.TabIndex = 33;
		FrameworkLabelValue.Text = "FrameworkLabelValue";
		// 
		// RepositoryLabelValue
		// 
		RepositoryLabelValue.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
		RepositoryLabelValue.AutoSize = true;
		RepositoryLabelValue.Location = new Point(459, 178);
		RepositoryLabelValue.Margin = new Padding(3);
		RepositoryLabelValue.Name = "RepositoryLabelValue";
		RepositoryLabelValue.Size = new Size(318, 25);
		RepositoryLabelValue.TabIndex = 34;
		RepositoryLabelValue.Text = "RepositoryLabelValue";
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
		// DescriptionLabelValue
		// 
		DescriptionLabelValue.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
		DescriptionLabelValue.AutoSize = true;
		DescriptionLabelValue.Location = new Point(459, 209);
		DescriptionLabelValue.Margin = new Padding(3);
		DescriptionLabelValue.Name = "DescriptionLabelValue";
		DescriptionLabelValue.Size = new Size(318, 25);
		DescriptionLabelValue.TabIndex = 36;
		DescriptionLabelValue.Text = "DescriptionLabelValue";
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
	private Label TitleLabelValue;
	private Label VersionLabelValue;
	private Label CompanyLabelValue;
	private Label CopyrightLabelValue;
	private Label FrameworkLabelValue;
	private Label RepositoryLabelValue;
	private Label DescriptionLabel;
	private Label DescriptionLabelValue;
}