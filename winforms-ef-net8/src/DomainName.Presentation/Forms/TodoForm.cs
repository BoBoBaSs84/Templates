using DomainName.Application.ViewModels;

namespace DomainName.Presentation.Forms;

/// <summary>
/// Represents the form for managing to-do items.
/// </summary>
public partial class TodoForm : Form
{
	private readonly TodoViewModel _viewModel;

	/// <summary>
	/// Initializes a new instance of the <see cref="TodoForm"/> class.
	/// </summary>
	public TodoForm(TodoViewModel viewModel)
	{
		InitializeComponent();
		_viewModel = viewModel;
	}

	private void bindingSource1_CurrentChanged(object sender, EventArgs e)
	{

	}
}
