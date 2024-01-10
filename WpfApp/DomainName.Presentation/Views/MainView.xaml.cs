using System.Windows;

using DomainName.Application.ViewModels;

namespace DomainName.Presentation.Views;

/// <summary>
/// Interaction logic for MainView.xaml
/// </summary>
public partial class MainView : Window
{
	/// <summary>
	/// Initializes an instance of the <see cref="MainView"/> class.
	/// </summary>
	/// <param name="viewModel">The view model instance to use.</param>
	public MainView(MainViewModel viewModel)
	{
		DataContext = viewModel;
		InitializeComponent();
	}
}
