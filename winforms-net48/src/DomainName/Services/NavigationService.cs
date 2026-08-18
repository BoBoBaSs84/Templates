using BB84.Notifications;

using DomainName.Application.Abstractions.Services;

namespace DomainName.Services;

/// <summary>
/// The navigation service class.
/// </summary>
internal sealed class NavigationService : NotifiableObject, INavigationService
{
	private readonly Func<Type, Form> _formFactory;

	/// <summary>
	/// Initializes a new instance of the <see cref="NavigationService"/> class.
	/// </summary>
	/// <param name="formFactory">The function for creating a specific form.</param>
	public NavigationService(Func<Type, Form> formFactory)
	{
		_formFactory = formFactory;

		PropertyChanging += (s, e) => CurrentForm?.Visible = false;
		PropertyChanged += (s, e) => CurrentForm?.Visible = true;
	}

	public Form? CurrentForm
	{
		get;
		private set => SetProperty(ref field, value);
	}

	public void NavigateTo<T>() where T : Form
	{
		Form form = _formFactory.Invoke(typeof(T));
		form.TopLevel = false;
		form.Dock = DockStyle.Fill;
		form.FormBorderStyle = FormBorderStyle.None;
		CurrentForm = form;
	}
}
