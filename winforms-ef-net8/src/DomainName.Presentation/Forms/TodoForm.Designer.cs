namespace DomainName.Presentation.Forms;

partial class TodoForm
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
		todoListBindingSource = new BindingSource(components);
		todoItemBindingSource = new BindingSource(components);
		tableLayoutPanel1 = new TableLayoutPanel();
		((System.ComponentModel.ISupportInitialize)todoListBindingSource).BeginInit();
		((System.ComponentModel.ISupportInitialize)todoItemBindingSource).BeginInit();
		SuspendLayout();
		// 
		// todoListBindingSource
		// 
		todoListBindingSource.DataSource = typeof(Domain.Entities.TodoList);
		// 
		// todoItemBindingSource
		// 
		todoItemBindingSource.DataSource = typeof(Domain.Entities.TodoItem);
		// 
		// tableLayoutPanel1
		// 
		tableLayoutPanel1.ColumnCount = 4;
		tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 5F));
		tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 45F));
		tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 45F));
		tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 5F));
		tableLayoutPanel1.Dock = DockStyle.Fill;
		tableLayoutPanel1.Location = new Point(0, 0);
		tableLayoutPanel1.Name = "tableLayoutPanel1";
		tableLayoutPanel1.RowCount = 4;
		tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 5F));
		tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 45F));
		tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 45F));
		tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 5F));
		tableLayoutPanel1.Size = new Size(800, 450);
		tableLayoutPanel1.TabIndex = 0;
		// 
		// TodoForm
		// 
		AutoScaleDimensions = new SizeF(10F, 25F);
		AutoScaleMode = AutoScaleMode.Font;
		ClientSize = new Size(800, 450);
		Controls.Add(tableLayoutPanel1);
		Name = "TodoForm";
		Text = "TodoForm";
		((System.ComponentModel.ISupportInitialize)todoListBindingSource).EndInit();
		((System.ComponentModel.ISupportInitialize)todoItemBindingSource).EndInit();
		ResumeLayout(false);
	}

	#endregion
	private BindingSource todoListBindingSource;
	private BindingSource todoItemBindingSource;
	private TableLayoutPanel tableLayoutPanel1;
}