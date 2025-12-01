using BB84.WinForms.Extensions;

using DomainName.Application.Abstractions.Application.Services;
using DomainName.Application.ViewModels;
using DomainName.Domain.Entities;
using DomainName.Domain.Events.Presentation;

namespace DomainName.Presentation.Forms;

/// <summary>
/// Represents the form for managing to-do items.
/// </summary>
public partial class TodoForm : Form
{
	private readonly IEventService _eventService;
	private readonly TodoViewModel _viewModel;

	/// <summary>
	/// Initializes a new instance of the <see cref="TodoForm"/> class.
	/// </summary>
	/// <param name="eventService">The event service instance to use.</param>
	/// <param name="viewModel">The to-do view model instance to use.</param>
	public TodoForm(IEventService eventService, TodoViewModel viewModel)
	{
		InitializeComponent();
		_eventService = eventService;
		_viewModel = viewModel;
		_viewModel.PropertyChanging += (s, e) => OnViewModelPropertyChanging(e.PropertyName);
		_viewModel.PropertyChanged += (s, e) => OnViewModelPropertyChanged(e.PropertyName);

		todoListGroupBox.DataBindings.Add(nameof(todoListGroupBox.Enabled), _viewModel, nameof(_viewModel.IsListSelected), true, DataSourceUpdateMode.OnPropertyChanged);
		todoItemGroupBox.DataBindings.Add(nameof(todoItemGroupBox.Enabled), _viewModel, nameof(_viewModel.IsItemSelected), true, DataSourceUpdateMode.OnPropertyChanged);

		todoListBindingSource.DataSource = _viewModel.Lists;

		FormClosing += (s, e) => _viewModel.SaveChanges();
		_eventService.Publish(new StatusChangedEvent($"{nameof(TodoForm)} initialized.."));
	}

	/// <inheritdoc/>
	protected override void OnLoad(EventArgs e)
	{
		base.OnLoad(e);
		_viewModel.LoadLists();
	}

	private void OnViewModelPropertyChanging(string? propertyName)
	{
		if (propertyName is nameof(_viewModel.SelectedList))
		{
			todoListTitleTextBox.DataBindings.Clear();
			todoListDescriptionTextBox.DataBindings.Clear();
		}
		else if (propertyName is nameof(_viewModel.SelectedItem))
		{
			todoItemTitleTextBox.DataBindings.Clear();
			todoItemDescriptionTextBox.DataBindings.Clear();
			todoItemPriorityComboBox.DataBindings.Clear();
			todoItemIsCompletedCheckBox.DataBindings.Clear();
		}
	}

	private void OnViewModelPropertyChanged(string? propertyName)
	{
		if (propertyName is nameof(_viewModel.SelectedList))
		{
			if (_viewModel.SelectedList is null)
				return;

			todoListTitleTextBox.WithTextBinding(_viewModel.SelectedList, nameof(_viewModel.SelectedList.Title));
			todoListDescriptionTextBox.WithTextBinding(_viewModel.SelectedList, nameof(_viewModel.SelectedList.Description));
			todoItemBindingSource.DataSource = _viewModel.SelectedList.Items;
			_viewModel.SelectedItem = _viewModel.SelectedList.Items.FirstOrDefault();
		}
		else if (propertyName is nameof(_viewModel.SelectedItem))
		{
			if (_viewModel.SelectedItem is null)
				return;

			todoItemTitleTextBox.WithTextBinding(_viewModel.SelectedItem, nameof(_viewModel.SelectedItem.Title));
			todoItemDescriptionTextBox.WithTextBinding(_viewModel.SelectedItem, nameof(_viewModel.SelectedItem.Description));
			todoItemPriorityComboBox.WithDataSourceBinding(_viewModel.Priorities);
			todoItemPriorityComboBox.WithSelectedItemBinding(_viewModel.SelectedItem, nameof(_viewModel.SelectedItem.Priority))
				.WithSelectedValueBinding(_viewModel.SelectedItem, nameof(_viewModel.SelectedItem.Priority));
			todoItemIsCompletedCheckBox.WithCheckedBinding(_viewModel.SelectedItem, nameof(_viewModel.SelectedItem.IsCompleted));
		}
	}

	private void TodoListColorButton_Click(object sender, EventArgs e)
	{
		if (_viewModel.SelectedList is null)
			return;

		ColorDialog colorDialog = new()
		{
			Color = _viewModel.SelectedList.Color ?? Color.Empty,
			AllowFullOpen = true,
			ShowHelp = true
		};

		if (colorDialog.ShowDialog() == DialogResult.OK)
			_viewModel.SelectedList.Color = colorDialog.Color;
	}

	private void TodoItemColorButton_Click(object sender, EventArgs e)
	{
		if (_viewModel.SelectedItem is null)
			return;

		ColorDialog colorDialog = new()
		{
			Color = _viewModel.SelectedItem.Color ?? Color.Empty,
			AllowFullOpen = true,
			ShowHelp = true
		};

		if (colorDialog.ShowDialog() == DialogResult.OK)
			_viewModel.SelectedItem.Color = colorDialog.Color;
	}

	private void TodoListAddButton_Click(object sender, EventArgs e)
	{
		TodoList list = new()
		{
			Title = "New List",
		};

		_viewModel.Lists.Add(list);
	}

	private void TodoItemAddButton_Click(object sender, EventArgs e)
	{
		if (_viewModel.SelectedList is null)
			return;

		TodoItem item = new()
		{
			Title = "New Item",
			List = _viewModel.SelectedList
		};

		_viewModel.SelectedList.Items.Add(item);
	}

	private void TodoListsDataGridView_SelectionChanged(object sender, EventArgs e)
	{
		if (todoListsDataGridView.SelectedRows.Count == 1)
		{
			TodoList? selectedList = todoListsDataGridView.SelectedRows[0].DataBoundItem as TodoList;
			_viewModel.SelectedList = selectedList;
		}
	}

	private void TodoItemsDataGridView_SelectionChanged(object sender, EventArgs e)
	{
		if (todoItemsDataGridView.SelectedRows.Count == 1)
		{
			TodoItem? selectedItem = todoItemsDataGridView.SelectedRows[0].DataBoundItem as TodoItem;
			_viewModel.SelectedItem = selectedItem;
		}
	}

	private void TodoListSaveButton_Click(object sender, EventArgs e)
		=> _viewModel.SaveChanges();
}
