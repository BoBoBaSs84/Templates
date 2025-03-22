using BB84.Notifications;

using DomainName.Domain.Models;

namespace DomainName.Application.ViewModels;

/// <summary>
/// Represents the main view model of the application.
/// </summary>
public sealed class MainViewModel : NotifiableObject
{
	/// <summary>
	/// Initializes a new instance of the <see cref="MainViewModel"/> class.
	/// </summary>
	public MainViewModel()
	{
		Model = new();

		Model.PropertyChanged += (s, e) => OnModelPropertyChanged(e.PropertyName);
	}

	/// <summary>
	/// The main model of the application.
	/// </summary>
	public MainModel Model { get; }

	/// <summary>
	/// Indicates whether the user can change the name.
	/// </summary>
	public bool CanChangeName => Model.Age <= 18;

	private void OnModelPropertyChanged(string? propertyName)
	{
		if (propertyName is nameof(Model.Age))
			RaisePropertyChanged(nameof(CanChangeName));
	}
}
