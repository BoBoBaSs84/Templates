using System.Windows;

using DomainName.Application.ViewModels;
using DomainName.Extensions;

using RESX = DomainName.Properties.Resources;

namespace DomainName.Windows;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
	/// <summary>
	/// Initializes an instance of the <see cref="MainWindow"/> class.
	/// </summary>
	/// <param name="viewModel">The view model instance to use.</param>
	public MainWindow(MainViewModel viewModel)
	{
		InitializeComponent();
		InitializeResources();
		DataContext = viewModel;
	}

	private void InitializeResources()
	{
		NewMenuItem.Icon = RESX.DocumentIcon.ToControlsImage();
		OpenMenuItem.Icon = RESX.FolderDocumentIcon.ToControlsImage();
		SettingsMenuItem.Icon = RESX.GearsViewIcon.ToControlsImage();
		ExitMenuItem.Icon = RESX.ExitIcon.ToControlsImage();
		AboutMenuItem.Icon = RESX.AboutIcon.ToControlsImage();
		CheckForUpdatesMenuItem.Icon = RESX.WindowNextIcon.ToControlsImage();
		WhatsNewMenuItem.Icon = RESX.NewspaperIcon.ToControlsImage();
		HelpMenuItem.Icon = RESX.QuestionAndAnswerIcon.ToControlsImage();
	}
}
