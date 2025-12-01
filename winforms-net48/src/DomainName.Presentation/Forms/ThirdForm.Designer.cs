namespace DomainName.Presentation.Forms;

partial class ThirdForm
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
			this.ThirdFormLabel = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// ThirdFormLabel
			// 
			this.ThirdFormLabel.AutoSize = true;
			this.ThirdFormLabel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.ThirdFormLabel.Location = new System.Drawing.Point(0, 0);
			this.ThirdFormLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.ThirdFormLabel.Name = "ThirdFormLabel";
			this.ThirdFormLabel.Size = new System.Drawing.Size(44, 16);
			this.ThirdFormLabel.TabIndex = 0;
			this.ThirdFormLabel.Text = "label1";
			this.ThirdFormLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// ThirdForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(640, 288);
			this.Controls.Add(this.ThirdFormLabel);
			this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.Name = "ThirdForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "ThirdForm";
			this.ResumeLayout(false);
			this.PerformLayout();

	}

	#endregion

	private Label ThirdFormLabel;
}