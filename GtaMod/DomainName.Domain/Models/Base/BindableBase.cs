using BB84.SourceGenerators.Attributes;

namespace DomainName.Domain.Models.Base;

/// <summary>
/// Represents a base class for bindable objects that implement the <c>INotifyPropertyChanged</c> and <c>INotifyPropertyChanging</c> interfaces.
/// </summary>
[GenerateNotifications]
public abstract partial class BindableBase
{
	/// <summary>
	/// Sets the property and raises the <see cref="PropertyChanging"/> and <see cref="PropertyChanged"/>
	/// events if the value has changed.
	/// </summary>
	/// <typeparam name="T">The type of the property.</typeparam>
	/// <param name="field">A reference to the field that backs the property.</param>
	/// <param name="value">The new value for the property.</param>
	/// <param name="propertyName">The name of the property.</param>
	protected virtual void SetProperty<T>(ref T field, T value, string propertyName)
	{
		if (!EqualityComparer<T>.Default.Equals(field, value))
		{
			RaisePropertyChanging(propertyName);
			field = value;
			RaisePropertyChanged(propertyName);
		}
	}
}
