using System.Drawing;
using System.Windows;
using System.Windows.Interop;
using System.Windows.Media;
using System.Windows.Media.Imaging;

using ControlsImage = System.Windows.Controls.Image;

namespace DomainName.Presentation.Extensions;

/// <summary>
/// Represents extension methods for the <see cref="Icon"/> class.
/// </summary>
internal static class IconExtensions
{
	/// <summary>
	/// Converts a <see cref="Icon"/> to an <see cref="ImageSource"/> that can be used in WPF controls.
	/// </summary>
	/// <param name="icon">The <see cref="Icon"/> to convert.</param>
	/// <returns>The converted <see cref="ImageSource"/> that can be used in WPF controls.</returns>
	public static ImageSource ToImageSource(this Icon icon)
	{
		ImageSource imageSource = Imaging.CreateBitmapSourceFromHIcon(
			icon.Handle,
			Int32Rect.Empty,
			BitmapSizeOptions.FromEmptyOptions()
			);

		return imageSource;
	}

	/// <summary>
	/// Converts a <see cref="Icon"/> to a <see cref="ControlsImage"/> that can be used in WPF controls.
	/// </summary>
	/// <param name="icon">The <see cref="Icon"/> to convert.</param>
	/// <returns>The converted <see cref="ControlsImage"/> that can be used in WPF controls.</returns>
	public static ControlsImage ToControlsImage(this Icon icon)
		=> new() { Source = icon.ToImageSource() };
}
