using System.Windows.Controls;

using RESX = DomainName.Presentation.Properties.Resources;

namespace DomainName.Presentation.Controls;

/// <summary>
/// Interaction logic for SettingsControl.xaml
/// </summary>
public partial class SettingsControl : UserControl
{
	/// <summary>
	/// Initializes a new instance of the <see cref="SettingsControl"/> class.
	/// </summary>
	public SettingsControl()
	{
		InitializeComponent();
		InitializeResources();
	}

	private void InitializeResources()
	{
		GeneralGroupBox.Header = RESX.SettingsControl_GeneralGroupBox_Header;
		LanguageTextBlock.Text = RESX.SettingsControl_LanguageTextBlock_Text;
	}
}
