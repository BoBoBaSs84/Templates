// Copyright: 2025 Robert Peter Meyer
// License: MIT
//
// This source code is licensed under the MIT license found in the
// LICENSE file in the root directory of this source tree.
using System.Diagnostics;
using System.Windows.Controls;
using System.Windows.Navigation;

using DomainName.Presentation.Extensions;

using RESX = DomainName.Presentation.Properties.Resources;

namespace DomainName.Presentation.Controls;

/// <summary>
/// Interaction logic for AboutControl.xaml
/// </summary>
public partial class AboutControl : UserControl
{
	/// <summary>
	/// Initializes an instance of the <see cref="AboutControl"/> class.
	/// </summary>
	public AboutControl()
	{
		InitializeComponent();
		InitializeResources();
	}

	private void InitializeResources()
	{
		AboutIcon.Source = RESX.AboutIcon.ToImageSource();
	}

	private void Hyperlink_RequestNavigate(object sender, RequestNavigateEventArgs e)
	{
		Process.Start(new ProcessStartInfo(e.Uri.AbsoluteUri) { UseShellExecute = true });
		e.Handled = true;
	}
}
