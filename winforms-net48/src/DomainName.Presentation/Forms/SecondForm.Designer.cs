namespace DomainName.Presentation.Forms;

partial class SecondForm
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
			this.SecondFormLabel = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// SecondFormLabel
			// 
			this.SecondFormLabel.AutoSize = true;
			this.SecondFormLabel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.SecondFormLabel.Location = new System.Drawing.Point(0, 0);
			this.SecondFormLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.SecondFormLabel.Name = "SecondFormLabel";
			this.SecondFormLabel.Size = new System.Drawing.Size(44, 16);
			this.SecondFormLabel.TabIndex = 0;
			this.SecondFormLabel.Text = "label1";
			this.SecondFormLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// SecondForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(640, 288);
			this.Controls.Add(this.SecondFormLabel);
			this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.Name = "SecondForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "SecondForm";
			this.ResumeLayout(false);
			this.PerformLayout();

	}

	#endregion

	private Label SecondFormLabel;
}