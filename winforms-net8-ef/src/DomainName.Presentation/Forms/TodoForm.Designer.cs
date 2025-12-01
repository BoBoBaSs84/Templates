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
		todoListGroupBox = new GroupBox();
		tableLayoutPanel2 = new TableLayoutPanel();
		todoListDescriptionTextBox = new TextBox();
		todoListColorLabel = new Label();
		todoListDescriptionLabel = new Label();
		todoListTitleLabel = new Label();
		todoListTitleTextBox = new TextBox();
		todoListColorButton = new Button();
		todoItemGroupBox = new GroupBox();
		tableLayoutPanel3 = new TableLayoutPanel();
		todoItemDescriptionTextBox = new TextBox();
		todoItemColorLabel = new Label();
		todoItemIsCompletedLabel = new Label();
		todoItemPriorityLabel = new Label();
		todoItemDescriptionLabel = new Label();
		todoItemTitleLabel = new Label();
		todoItemIsCompletedCheckBox = new CheckBox();
		todoItemPriorityComboBox = new ComboBox();
		todoItemTitleTextBox = new TextBox();
		todoItemColorButton = new Button();
		todoListsGroupBox = new GroupBox();
		tableLayoutPanel4 = new TableLayoutPanel();
		todoListsDataGridView = new DataGridView();
		idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
		titleDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
		descriptionDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
		colorDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
		todoListAddButton = new Button();
		todoListDeleteButton = new Button();
		todoListSaveButton = new Button();
		todoItemsGroupBox = new GroupBox();
		tableLayoutPanel5 = new TableLayoutPanel();
		todoItemsDataGridView = new DataGridView();
		idDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
		titleDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
		descriptionDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
		priorityDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
		isCompletedDataGridViewCheckBoxColumn = new DataGridViewCheckBoxColumn();
		colorDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
		itemsBindingSource = new BindingSource(components);
		todoItemAddButton = new Button();
		todoItemDeleteButton = new Button();
		todoListBindingSource2 = new BindingSource(components);
		todoListBindingSource3 = new BindingSource(components);
		todoListBindingSource1 = new BindingSource(components);
		((System.ComponentModel.ISupportInitialize)todoListBindingSource).BeginInit();
		((System.ComponentModel.ISupportInitialize)todoItemBindingSource).BeginInit();
		tableLayoutPanel1.SuspendLayout();
		todoListGroupBox.SuspendLayout();
		tableLayoutPanel2.SuspendLayout();
		todoItemGroupBox.SuspendLayout();
		tableLayoutPanel3.SuspendLayout();
		todoListsGroupBox.SuspendLayout();
		tableLayoutPanel4.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)todoListsDataGridView).BeginInit();
		todoItemsGroupBox.SuspendLayout();
		tableLayoutPanel5.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)todoItemsDataGridView).BeginInit();
		((System.ComponentModel.ISupportInitialize)itemsBindingSource).BeginInit();
		((System.ComponentModel.ISupportInitialize)todoListBindingSource2).BeginInit();
		((System.ComponentModel.ISupportInitialize)todoListBindingSource3).BeginInit();
		((System.ComponentModel.ISupportInitialize)todoListBindingSource1).BeginInit();
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
		tableLayoutPanel1.Controls.Add(todoListGroupBox, 1, 1);
		tableLayoutPanel1.Controls.Add(todoItemGroupBox, 2, 1);
		tableLayoutPanel1.Controls.Add(todoListsGroupBox, 1, 2);
		tableLayoutPanel1.Controls.Add(todoItemsGroupBox, 2, 2);
		tableLayoutPanel1.Dock = DockStyle.Fill;
		tableLayoutPanel1.Location = new Point(0, 0);
		tableLayoutPanel1.Name = "tableLayoutPanel1";
		tableLayoutPanel1.RowCount = 4;
		tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 5F));
		tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 45F));
		tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 45F));
		tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 5F));
		tableLayoutPanel1.Size = new Size(978, 544);
		tableLayoutPanel1.TabIndex = 0;
		// 
		// todoListGroupBox
		// 
		todoListGroupBox.Controls.Add(tableLayoutPanel2);
		todoListGroupBox.Dock = DockStyle.Fill;
		todoListGroupBox.Location = new Point(51, 30);
		todoListGroupBox.Name = "todoListGroupBox";
		todoListGroupBox.Size = new Size(434, 238);
		todoListGroupBox.TabIndex = 0;
		todoListGroupBox.TabStop = false;
		todoListGroupBox.Text = "Todo list";
		// 
		// tableLayoutPanel2
		// 
		tableLayoutPanel2.ColumnCount = 2;
		tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle());
		tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle());
		tableLayoutPanel2.Controls.Add(todoListDescriptionTextBox, 1, 1);
		tableLayoutPanel2.Controls.Add(todoListColorLabel, 0, 2);
		tableLayoutPanel2.Controls.Add(todoListDescriptionLabel, 0, 1);
		tableLayoutPanel2.Controls.Add(todoListTitleLabel, 0, 0);
		tableLayoutPanel2.Controls.Add(todoListTitleTextBox, 1, 0);
		tableLayoutPanel2.Controls.Add(todoListColorButton, 1, 2);
		tableLayoutPanel2.Dock = DockStyle.Fill;
		tableLayoutPanel2.Location = new Point(3, 27);
		tableLayoutPanel2.Name = "tableLayoutPanel2";
		tableLayoutPanel2.RowCount = 4;
		tableLayoutPanel2.RowStyles.Add(new RowStyle());
		tableLayoutPanel2.RowStyles.Add(new RowStyle());
		tableLayoutPanel2.RowStyles.Add(new RowStyle());
		tableLayoutPanel2.RowStyles.Add(new RowStyle());
		tableLayoutPanel2.Size = new Size(428, 208);
		tableLayoutPanel2.TabIndex = 0;
		// 
		// todoListDescriptionTextBox
		// 
		todoListDescriptionTextBox.Anchor = AnchorStyles.Left | AnchorStyles.Right;
		todoListDescriptionTextBox.Location = new Point(115, 40);
		todoListDescriptionTextBox.Name = "todoListDescriptionTextBox";
		todoListDescriptionTextBox.Size = new Size(310, 31);
		todoListDescriptionTextBox.TabIndex = 7;
		// 
		// todoListColorLabel
		// 
		todoListColorLabel.Anchor = AnchorStyles.Left;
		todoListColorLabel.AutoSize = true;
		todoListColorLabel.Location = new Point(3, 81);
		todoListColorLabel.Name = "todoListColorLabel";
		todoListColorLabel.Size = new Size(59, 25);
		todoListColorLabel.TabIndex = 5;
		todoListColorLabel.Text = "Color:";
		// 
		// todoListDescriptionLabel
		// 
		todoListDescriptionLabel.Anchor = AnchorStyles.Left;
		todoListDescriptionLabel.AutoSize = true;
		todoListDescriptionLabel.Location = new Point(3, 43);
		todoListDescriptionLabel.Name = "todoListDescriptionLabel";
		todoListDescriptionLabel.Size = new Size(106, 25);
		todoListDescriptionLabel.TabIndex = 2;
		todoListDescriptionLabel.Text = "Description:";
		// 
		// todoListTitleLabel
		// 
		todoListTitleLabel.Anchor = AnchorStyles.Left;
		todoListTitleLabel.AutoSize = true;
		todoListTitleLabel.Location = new Point(3, 6);
		todoListTitleLabel.Name = "todoListTitleLabel";
		todoListTitleLabel.Size = new Size(48, 25);
		todoListTitleLabel.TabIndex = 0;
		todoListTitleLabel.Text = "Title:";
		// 
		// todoListTitleTextBox
		// 
		todoListTitleTextBox.Anchor = AnchorStyles.Left | AnchorStyles.Right;
		todoListTitleTextBox.Location = new Point(115, 3);
		todoListTitleTextBox.Name = "todoListTitleTextBox";
		todoListTitleTextBox.Size = new Size(310, 31);
		todoListTitleTextBox.TabIndex = 6;
		// 
		// todoListColorButton
		// 
		todoListColorButton.Anchor = AnchorStyles.Left;
		todoListColorButton.Location = new Point(115, 77);
		todoListColorButton.Name = "todoListColorButton";
		todoListColorButton.Size = new Size(100, 34);
		todoListColorButton.TabIndex = 8;
		todoListColorButton.Text = "Choose";
		todoListColorButton.UseVisualStyleBackColor = true;
		todoListColorButton.Click += TodoListColorButton_Click;
		// 
		// todoItemGroupBox
		// 
		todoItemGroupBox.Controls.Add(tableLayoutPanel3);
		todoItemGroupBox.Dock = DockStyle.Fill;
		todoItemGroupBox.Location = new Point(491, 30);
		todoItemGroupBox.Name = "todoItemGroupBox";
		todoItemGroupBox.Size = new Size(434, 238);
		todoItemGroupBox.TabIndex = 1;
		todoItemGroupBox.TabStop = false;
		todoItemGroupBox.Text = "Todo item";
		// 
		// tableLayoutPanel3
		// 
		tableLayoutPanel3.ColumnCount = 2;
		tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle());
		tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle());
		tableLayoutPanel3.Controls.Add(todoItemDescriptionTextBox, 1, 1);
		tableLayoutPanel3.Controls.Add(todoItemColorLabel, 0, 4);
		tableLayoutPanel3.Controls.Add(todoItemIsCompletedLabel, 0, 3);
		tableLayoutPanel3.Controls.Add(todoItemPriorityLabel, 0, 2);
		tableLayoutPanel3.Controls.Add(todoItemDescriptionLabel, 0, 1);
		tableLayoutPanel3.Controls.Add(todoItemTitleLabel, 0, 0);
		tableLayoutPanel3.Controls.Add(todoItemIsCompletedCheckBox, 1, 3);
		tableLayoutPanel3.Controls.Add(todoItemPriorityComboBox, 1, 2);
		tableLayoutPanel3.Controls.Add(todoItemTitleTextBox, 1, 0);
		tableLayoutPanel3.Controls.Add(todoItemColorButton, 1, 4);
		tableLayoutPanel3.Dock = DockStyle.Fill;
		tableLayoutPanel3.Location = new Point(3, 27);
		tableLayoutPanel3.Name = "tableLayoutPanel3";
		tableLayoutPanel3.RowCount = 6;
		tableLayoutPanel3.RowStyles.Add(new RowStyle());
		tableLayoutPanel3.RowStyles.Add(new RowStyle());
		tableLayoutPanel3.RowStyles.Add(new RowStyle());
		tableLayoutPanel3.RowStyles.Add(new RowStyle());
		tableLayoutPanel3.RowStyles.Add(new RowStyle());
		tableLayoutPanel3.RowStyles.Add(new RowStyle());
		tableLayoutPanel3.Size = new Size(428, 208);
		tableLayoutPanel3.TabIndex = 0;
		// 
		// todoItemDescriptionTextBox
		// 
		todoItemDescriptionTextBox.Anchor = AnchorStyles.Left | AnchorStyles.Right;
		todoItemDescriptionTextBox.Location = new Point(126, 40);
		todoItemDescriptionTextBox.Name = "todoItemDescriptionTextBox";
		todoItemDescriptionTextBox.Size = new Size(299, 31);
		todoItemDescriptionTextBox.TabIndex = 12;
		// 
		// todoItemColorLabel
		// 
		todoItemColorLabel.Anchor = AnchorStyles.Left;
		todoItemColorLabel.AutoSize = true;
		todoItemColorLabel.Location = new Point(3, 155);
		todoItemColorLabel.Name = "todoItemColorLabel";
		todoItemColorLabel.Size = new Size(59, 25);
		todoItemColorLabel.TabIndex = 8;
		todoItemColorLabel.Text = "Color:";
		// 
		// todoItemIsCompletedLabel
		// 
		todoItemIsCompletedLabel.Anchor = AnchorStyles.Left;
		todoItemIsCompletedLabel.AutoSize = true;
		todoItemIsCompletedLabel.Location = new Point(3, 118);
		todoItemIsCompletedLabel.Name = "todoItemIsCompletedLabel";
		todoItemIsCompletedLabel.Size = new Size(117, 25);
		todoItemIsCompletedLabel.TabIndex = 6;
		todoItemIsCompletedLabel.Text = "IsCompleted:";
		// 
		// todoItemPriorityLabel
		// 
		todoItemPriorityLabel.Anchor = AnchorStyles.Left;
		todoItemPriorityLabel.AutoSize = true;
		todoItemPriorityLabel.Location = new Point(3, 81);
		todoItemPriorityLabel.Name = "todoItemPriorityLabel";
		todoItemPriorityLabel.Size = new Size(72, 25);
		todoItemPriorityLabel.TabIndex = 4;
		todoItemPriorityLabel.Text = "Priority:";
		// 
		// todoItemDescriptionLabel
		// 
		todoItemDescriptionLabel.Anchor = AnchorStyles.Left;
		todoItemDescriptionLabel.AutoSize = true;
		todoItemDescriptionLabel.Location = new Point(3, 43);
		todoItemDescriptionLabel.Name = "todoItemDescriptionLabel";
		todoItemDescriptionLabel.Size = new Size(106, 25);
		todoItemDescriptionLabel.TabIndex = 2;
		todoItemDescriptionLabel.Text = "Description:";
		// 
		// todoItemTitleLabel
		// 
		todoItemTitleLabel.Anchor = AnchorStyles.Left;
		todoItemTitleLabel.AutoSize = true;
		todoItemTitleLabel.Location = new Point(3, 6);
		todoItemTitleLabel.Name = "todoItemTitleLabel";
		todoItemTitleLabel.Size = new Size(48, 25);
		todoItemTitleLabel.TabIndex = 0;
		todoItemTitleLabel.Text = "Title:";
		// 
		// todoItemIsCompletedCheckBox
		// 
		todoItemIsCompletedCheckBox.AutoSize = true;
		todoItemIsCompletedCheckBox.Location = new Point(126, 116);
		todoItemIsCompletedCheckBox.Name = "todoItemIsCompletedCheckBox";
		todoItemIsCompletedCheckBox.Size = new Size(94, 29);
		todoItemIsCompletedCheckBox.TabIndex = 9;
		todoItemIsCompletedCheckBox.Text = "Yes/No";
		todoItemIsCompletedCheckBox.UseVisualStyleBackColor = true;
		// 
		// todoItemPriorityComboBox
		// 
		todoItemPriorityComboBox.Anchor = AnchorStyles.Left | AnchorStyles.Right;
		todoItemPriorityComboBox.FormattingEnabled = true;
		todoItemPriorityComboBox.Location = new Point(126, 77);
		todoItemPriorityComboBox.Name = "todoItemPriorityComboBox";
		todoItemPriorityComboBox.Size = new Size(299, 33);
		todoItemPriorityComboBox.TabIndex = 10;
		// 
		// todoItemTitleTextBox
		// 
		todoItemTitleTextBox.Anchor = AnchorStyles.Left | AnchorStyles.Right;
		todoItemTitleTextBox.Location = new Point(126, 3);
		todoItemTitleTextBox.Name = "todoItemTitleTextBox";
		todoItemTitleTextBox.Size = new Size(299, 31);
		todoItemTitleTextBox.TabIndex = 11;
		// 
		// todoItemColorButton
		// 
		todoItemColorButton.Anchor = AnchorStyles.Left;
		todoItemColorButton.Location = new Point(126, 151);
		todoItemColorButton.Name = "todoItemColorButton";
		todoItemColorButton.Size = new Size(100, 34);
		todoItemColorButton.TabIndex = 13;
		todoItemColorButton.Text = "Choose";
		todoItemColorButton.UseVisualStyleBackColor = true;
		todoItemColorButton.Click += TodoItemColorButton_Click;
		// 
		// todoListsGroupBox
		// 
		todoListsGroupBox.Controls.Add(tableLayoutPanel4);
		todoListsGroupBox.Dock = DockStyle.Fill;
		todoListsGroupBox.Location = new Point(51, 274);
		todoListsGroupBox.Name = "todoListsGroupBox";
		todoListsGroupBox.Size = new Size(434, 238);
		todoListsGroupBox.TabIndex = 2;
		todoListsGroupBox.TabStop = false;
		todoListsGroupBox.Text = "Todo lists";
		// 
		// tableLayoutPanel4
		// 
		tableLayoutPanel4.ColumnCount = 3;
		tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle());
		tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle());
		tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle());
		tableLayoutPanel4.Controls.Add(todoListsDataGridView, 0, 0);
		tableLayoutPanel4.Controls.Add(todoListAddButton, 0, 1);
		tableLayoutPanel4.Controls.Add(todoListDeleteButton, 1, 1);
		tableLayoutPanel4.Controls.Add(todoListSaveButton, 2, 1);
		tableLayoutPanel4.Dock = DockStyle.Fill;
		tableLayoutPanel4.Location = new Point(3, 27);
		tableLayoutPanel4.Name = "tableLayoutPanel4";
		tableLayoutPanel4.RowCount = 2;
		tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
		tableLayoutPanel4.RowStyles.Add(new RowStyle());
		tableLayoutPanel4.Size = new Size(428, 208);
		tableLayoutPanel4.TabIndex = 0;
		// 
		// todoListsDataGridView
		// 
		todoListsDataGridView.AllowUserToAddRows = false;
		todoListsDataGridView.AllowUserToDeleteRows = false;
		todoListsDataGridView.AllowUserToOrderColumns = true;
		todoListsDataGridView.AutoGenerateColumns = false;
		todoListsDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
		todoListsDataGridView.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn, titleDataGridViewTextBoxColumn, descriptionDataGridViewTextBoxColumn, colorDataGridViewTextBoxColumn });
		tableLayoutPanel4.SetColumnSpan(todoListsDataGridView, 3);
		todoListsDataGridView.DataSource = todoListBindingSource;
		todoListsDataGridView.Dock = DockStyle.Fill;
		todoListsDataGridView.Location = new Point(3, 3);
		todoListsDataGridView.Name = "todoListsDataGridView";
		todoListsDataGridView.ReadOnly = true;
		todoListsDataGridView.RowHeadersWidth = 62;
		todoListsDataGridView.Size = new Size(428, 162);
		todoListsDataGridView.TabIndex = 1;
		todoListsDataGridView.SelectionChanged += TodoListsDataGridView_SelectionChanged;
		// 
		// idDataGridViewTextBoxColumn
		// 
		idDataGridViewTextBoxColumn.DataPropertyName = "Id";
		idDataGridViewTextBoxColumn.HeaderText = "Id";
		idDataGridViewTextBoxColumn.MinimumWidth = 8;
		idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
		idDataGridViewTextBoxColumn.ReadOnly = true;
		idDataGridViewTextBoxColumn.Width = 150;
		// 
		// titleDataGridViewTextBoxColumn
		// 
		titleDataGridViewTextBoxColumn.DataPropertyName = "Title";
		titleDataGridViewTextBoxColumn.HeaderText = "Title";
		titleDataGridViewTextBoxColumn.MinimumWidth = 8;
		titleDataGridViewTextBoxColumn.Name = "titleDataGridViewTextBoxColumn";
		titleDataGridViewTextBoxColumn.ReadOnly = true;
		titleDataGridViewTextBoxColumn.Width = 150;
		// 
		// descriptionDataGridViewTextBoxColumn
		// 
		descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
		descriptionDataGridViewTextBoxColumn.HeaderText = "Description";
		descriptionDataGridViewTextBoxColumn.MinimumWidth = 8;
		descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
		descriptionDataGridViewTextBoxColumn.ReadOnly = true;
		descriptionDataGridViewTextBoxColumn.Width = 150;
		// 
		// colorDataGridViewTextBoxColumn
		// 
		colorDataGridViewTextBoxColumn.DataPropertyName = "Color";
		colorDataGridViewTextBoxColumn.HeaderText = "Color";
		colorDataGridViewTextBoxColumn.MinimumWidth = 8;
		colorDataGridViewTextBoxColumn.Name = "colorDataGridViewTextBoxColumn";
		colorDataGridViewTextBoxColumn.ReadOnly = true;
		colorDataGridViewTextBoxColumn.Width = 150;
		// 
		// todoListAddButton
		// 
		todoListAddButton.Location = new Point(3, 171);
		todoListAddButton.Name = "todoListAddButton";
		todoListAddButton.Size = new Size(112, 34);
		todoListAddButton.TabIndex = 2;
		todoListAddButton.Text = "Add";
		todoListAddButton.UseVisualStyleBackColor = true;
		todoListAddButton.Click += TodoListAddButton_Click;
		// 
		// todoListDeleteButton
		// 
		todoListDeleteButton.Location = new Point(121, 171);
		todoListDeleteButton.Name = "todoListDeleteButton";
		todoListDeleteButton.Size = new Size(112, 34);
		todoListDeleteButton.TabIndex = 3;
		todoListDeleteButton.Text = "Delete";
		todoListDeleteButton.UseVisualStyleBackColor = true;
		// 
		// todoListSaveButton
		// 
		todoListSaveButton.Location = new Point(239, 171);
		todoListSaveButton.Name = "todoListSaveButton";
		todoListSaveButton.Size = new Size(112, 34);
		todoListSaveButton.TabIndex = 4;
		todoListSaveButton.Text = "Save";
		todoListSaveButton.UseVisualStyleBackColor = true;
		todoListSaveButton.Click += TodoListSaveButton_Click;
		// 
		// todoItemsGroupBox
		// 
		todoItemsGroupBox.Controls.Add(tableLayoutPanel5);
		todoItemsGroupBox.Dock = DockStyle.Fill;
		todoItemsGroupBox.Location = new Point(491, 274);
		todoItemsGroupBox.Name = "todoItemsGroupBox";
		todoItemsGroupBox.Size = new Size(434, 238);
		todoItemsGroupBox.TabIndex = 3;
		todoItemsGroupBox.TabStop = false;
		todoItemsGroupBox.Text = "Todo items";
		// 
		// tableLayoutPanel5
		// 
		tableLayoutPanel5.ColumnCount = 3;
		tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle());
		tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle());
		tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle());
		tableLayoutPanel5.Controls.Add(todoItemsDataGridView, 0, 0);
		tableLayoutPanel5.Controls.Add(todoItemAddButton, 0, 1);
		tableLayoutPanel5.Controls.Add(todoItemDeleteButton, 1, 1);
		tableLayoutPanel5.Dock = DockStyle.Fill;
		tableLayoutPanel5.Location = new Point(3, 27);
		tableLayoutPanel5.Name = "tableLayoutPanel5";
		tableLayoutPanel5.RowCount = 2;
		tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
		tableLayoutPanel5.RowStyles.Add(new RowStyle());
		tableLayoutPanel5.Size = new Size(428, 208);
		tableLayoutPanel5.TabIndex = 0;
		// 
		// todoItemsDataGridView
		// 
		todoItemsDataGridView.AllowUserToAddRows = false;
		todoItemsDataGridView.AllowUserToDeleteRows = false;
		todoItemsDataGridView.AllowUserToOrderColumns = true;
		todoItemsDataGridView.AutoGenerateColumns = false;
		todoItemsDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
		todoItemsDataGridView.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn1, titleDataGridViewTextBoxColumn1, descriptionDataGridViewTextBoxColumn1, priorityDataGridViewTextBoxColumn, isCompletedDataGridViewCheckBoxColumn, colorDataGridViewTextBoxColumn1 });
		tableLayoutPanel5.SetColumnSpan(todoItemsDataGridView, 3);
		todoItemsDataGridView.DataSource = itemsBindingSource;
		todoItemsDataGridView.Dock = DockStyle.Fill;
		todoItemsDataGridView.Location = new Point(3, 3);
		todoItemsDataGridView.Name = "todoItemsDataGridView";
		todoItemsDataGridView.ReadOnly = true;
		todoItemsDataGridView.RowHeadersWidth = 62;
		todoItemsDataGridView.Size = new Size(428, 162);
		todoItemsDataGridView.TabIndex = 1;
		todoItemsDataGridView.SelectionChanged += TodoItemsDataGridView_SelectionChanged;
		// 
		// idDataGridViewTextBoxColumn1
		// 
		idDataGridViewTextBoxColumn1.DataPropertyName = "Id";
		idDataGridViewTextBoxColumn1.HeaderText = "Id";
		idDataGridViewTextBoxColumn1.MinimumWidth = 8;
		idDataGridViewTextBoxColumn1.Name = "idDataGridViewTextBoxColumn1";
		idDataGridViewTextBoxColumn1.ReadOnly = true;
		idDataGridViewTextBoxColumn1.Width = 150;
		// 
		// titleDataGridViewTextBoxColumn1
		// 
		titleDataGridViewTextBoxColumn1.DataPropertyName = "Title";
		titleDataGridViewTextBoxColumn1.HeaderText = "Title";
		titleDataGridViewTextBoxColumn1.MinimumWidth = 8;
		titleDataGridViewTextBoxColumn1.Name = "titleDataGridViewTextBoxColumn1";
		titleDataGridViewTextBoxColumn1.ReadOnly = true;
		titleDataGridViewTextBoxColumn1.Width = 150;
		// 
		// descriptionDataGridViewTextBoxColumn1
		// 
		descriptionDataGridViewTextBoxColumn1.DataPropertyName = "Description";
		descriptionDataGridViewTextBoxColumn1.HeaderText = "Description";
		descriptionDataGridViewTextBoxColumn1.MinimumWidth = 8;
		descriptionDataGridViewTextBoxColumn1.Name = "descriptionDataGridViewTextBoxColumn1";
		descriptionDataGridViewTextBoxColumn1.ReadOnly = true;
		descriptionDataGridViewTextBoxColumn1.Width = 150;
		// 
		// priorityDataGridViewTextBoxColumn
		// 
		priorityDataGridViewTextBoxColumn.DataPropertyName = "Priority";
		priorityDataGridViewTextBoxColumn.HeaderText = "Priority";
		priorityDataGridViewTextBoxColumn.MinimumWidth = 8;
		priorityDataGridViewTextBoxColumn.Name = "priorityDataGridViewTextBoxColumn";
		priorityDataGridViewTextBoxColumn.ReadOnly = true;
		priorityDataGridViewTextBoxColumn.Width = 150;
		// 
		// isCompletedDataGridViewCheckBoxColumn
		// 
		isCompletedDataGridViewCheckBoxColumn.DataPropertyName = "IsCompleted";
		isCompletedDataGridViewCheckBoxColumn.HeaderText = "IsCompleted";
		isCompletedDataGridViewCheckBoxColumn.MinimumWidth = 8;
		isCompletedDataGridViewCheckBoxColumn.Name = "isCompletedDataGridViewCheckBoxColumn";
		isCompletedDataGridViewCheckBoxColumn.ReadOnly = true;
		isCompletedDataGridViewCheckBoxColumn.Width = 150;
		// 
		// colorDataGridViewTextBoxColumn1
		// 
		colorDataGridViewTextBoxColumn1.DataPropertyName = "Color";
		colorDataGridViewTextBoxColumn1.HeaderText = "Color";
		colorDataGridViewTextBoxColumn1.MinimumWidth = 8;
		colorDataGridViewTextBoxColumn1.Name = "colorDataGridViewTextBoxColumn1";
		colorDataGridViewTextBoxColumn1.ReadOnly = true;
		colorDataGridViewTextBoxColumn1.Width = 150;
		// 
		// itemsBindingSource
		// 
		itemsBindingSource.DataMember = "Items";
		itemsBindingSource.DataSource = todoListBindingSource;
		// 
		// todoItemAddButton
		// 
		todoItemAddButton.Location = new Point(3, 171);
		todoItemAddButton.Name = "todoItemAddButton";
		todoItemAddButton.Size = new Size(112, 34);
		todoItemAddButton.TabIndex = 2;
		todoItemAddButton.Text = "Add";
		todoItemAddButton.UseVisualStyleBackColor = true;
		todoItemAddButton.Click += TodoItemAddButton_Click;
		// 
		// todoItemDeleteButton
		// 
		todoItemDeleteButton.Location = new Point(121, 171);
		todoItemDeleteButton.Name = "todoItemDeleteButton";
		todoItemDeleteButton.Size = new Size(112, 34);
		todoItemDeleteButton.TabIndex = 3;
		todoItemDeleteButton.Text = "Delete";
		todoItemDeleteButton.UseVisualStyleBackColor = true;
		// 
		// todoListBindingSource2
		// 
		todoListBindingSource2.DataSource = typeof(Domain.Entities.TodoList);
		// 
		// todoListBindingSource3
		// 
		todoListBindingSource3.DataSource = typeof(Domain.Entities.TodoList);
		// 
		// todoListBindingSource1
		// 
		todoListBindingSource1.DataSource = typeof(Domain.Entities.TodoList);
		// 
		// TodoForm
		// 
		AutoScaleDimensions = new SizeF(10F, 25F);
		AutoScaleMode = AutoScaleMode.Font;
		ClientSize = new Size(978, 544);
		Controls.Add(tableLayoutPanel1);
		Name = "TodoForm";
		Text = "TodoForm";
		((System.ComponentModel.ISupportInitialize)todoListBindingSource).EndInit();
		((System.ComponentModel.ISupportInitialize)todoItemBindingSource).EndInit();
		tableLayoutPanel1.ResumeLayout(false);
		todoListGroupBox.ResumeLayout(false);
		tableLayoutPanel2.ResumeLayout(false);
		tableLayoutPanel2.PerformLayout();
		todoItemGroupBox.ResumeLayout(false);
		tableLayoutPanel3.ResumeLayout(false);
		tableLayoutPanel3.PerformLayout();
		todoListsGroupBox.ResumeLayout(false);
		tableLayoutPanel4.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)todoListsDataGridView).EndInit();
		todoItemsGroupBox.ResumeLayout(false);
		tableLayoutPanel5.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)todoItemsDataGridView).EndInit();
		((System.ComponentModel.ISupportInitialize)itemsBindingSource).EndInit();
		((System.ComponentModel.ISupportInitialize)todoListBindingSource2).EndInit();
		((System.ComponentModel.ISupportInitialize)todoListBindingSource3).EndInit();
		((System.ComponentModel.ISupportInitialize)todoListBindingSource1).EndInit();
		ResumeLayout(false);
	}

	#endregion
	private BindingSource todoListBindingSource;
	private BindingSource todoItemBindingSource;
	private TableLayoutPanel tableLayoutPanel1;
	private GroupBox todoListGroupBox;
	private GroupBox todoItemGroupBox;
	private GroupBox todoListsGroupBox;
	private GroupBox todoItemsGroupBox;
	private TableLayoutPanel tableLayoutPanel2;
	private Label todoListDescriptionLabel;
	private Label todoListTitleLabel;
	private Label todoListColorLabel;
	private TextBox todoListTitleTextBox;
	private TextBox todoListDescriptionTextBox;
	private TableLayoutPanel tableLayoutPanel3;
	private Label todoItemColorLabel;
	private Label todoItemIsCompletedLabel;
	private Label todoItemPriorityLabel;
	private Label todoItemDescriptionLabel;
	private Label todoItemTitleLabel;
	private CheckBox todoItemIsCompletedCheckBox;
	private ComboBox todoItemPriorityComboBox;
	private TextBox todoItemTitleTextBox;
	private TextBox todoItemDescriptionTextBox;
	private Button todoItemColorButton;
	private TableLayoutPanel tableLayoutPanel4;
	private DataGridView todoListsDataGridView;
	private Button todoListAddButton;
	private Button todoListDeleteButton;
	private TableLayoutPanel tableLayoutPanel5;
	private DataGridView todoItemsDataGridView;
	private Button todoItemAddButton;
	private Button todoItemDeleteButton;
	private Button todoListColorButton;
	private Button todoListSaveButton;
	private BindingSource todoListBindingSource1;
	private BindingSource todoListBindingSource2;
	private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
	private DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn;
	private DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
	private DataGridViewTextBoxColumn colorDataGridViewTextBoxColumn;
	private BindingSource todoListBindingSource3;
	private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn1;
	private DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn1;
	private DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn1;
	private DataGridViewTextBoxColumn priorityDataGridViewTextBoxColumn;
	private DataGridViewCheckBoxColumn isCompletedDataGridViewCheckBoxColumn;
	private DataGridViewTextBoxColumn colorDataGridViewTextBoxColumn1;
	private BindingSource itemsBindingSource;
}