using BB84.Notifications;

namespace DomainName.Domain.Models;

/// <summary>
/// Represents the main model of the application.
/// </summary>
public sealed class MainModel : NotifiableObject
{
	private string _name = string.Empty;
	private int _age;

	/// <summary>
	/// The name of the user.
	/// </summary>
	public string Name { get => _name; set => SetProperty(ref _name, value); }

	/// <summary>
	/// The age of the user.
	/// </summary>
	public int Age { get => _age; set => SetProperty(ref _age, value); }
}
