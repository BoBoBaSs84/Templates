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
		((System.ComponentModel.ISupportInitialize)settingsViewModelBindingSource).BeginInit();
		SuspendLayout();
		// 
		// settingsViewModelBindingSource
		// 
		settingsViewModelBindingSource.DataSource = typeof(Application.ViewModels.SettingsViewModel);
		// 
		// SettingsForm
		// 
		AutoScaleDimensions = new SizeF(10F, 25F);
		AutoScaleMode = AutoScaleMode.Font;
		ClientSize = new Size(800, 450);
		Name = "SettingsForm";
		Text = "SettingsForm";
		((System.ComponentModel.ISupportInitialize)settingsViewModelBindingSource).EndInit();
		ResumeLayout(false);
	}

	#endregion

	private BindingSource settingsViewModelBindingSource;
}