using System.Globalization;
using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace DomainName.Presentation.Behaviors;

/// <summary>
/// Provides attached behavior for <see cref="TextBox"/> controls to allow integer-only input
/// and format values using the current culture's group separators.
/// </summary>
public static partial class IntegerTextBoxBehavior
{
	private static readonly Regex NonDigitRegex = CreateNonDigitRegex();

	/// <summary>
	/// Gets a value indicating whether integer behavior is enabled for the specified <see cref="TextBox"/>.
	/// </summary>
	public static bool GetIsEnabled(DependencyObject obj)
		=> (bool)obj.GetValue(IsEnabledProperty);

	/// <summary>
	/// Sets a value indicating whether integer behavior is enabled for the specified <see cref="TextBox"/>.
	/// </summary>
	public static void SetIsEnabled(DependencyObject obj, bool value)
		=> obj.SetValue(IsEnabledProperty, value);

	/// <summary>
	/// Identifies the attached property that enables integer behavior.
	/// </summary>
	public static readonly DependencyProperty IsEnabledProperty = DependencyProperty.RegisterAttached(
		"IsEnabled",
		typeof(bool),
		typeof(IntegerTextBoxBehavior),
		new PropertyMetadata(false, OnIsEnabledChanged));

	private static void OnIsEnabledChanged(DependencyObject dependencyObject, DependencyPropertyChangedEventArgs eventArgs)
	{
		if (dependencyObject is not TextBox textBox)
			return;

		if ((bool)eventArgs.NewValue)
		{
			textBox.PreviewTextInput += TextBoxOnPreviewTextInput;
			textBox.PreviewKeyDown += TextBoxOnPreviewKeyDown;
			textBox.GotFocus += TextBoxOnGotFocus;
			textBox.LostFocus += TextBoxOnLostFocus;
			textBox.Loaded += TextBoxOnLoaded;
			DataObject.AddPastingHandler(textBox, TextBoxOnPasting);
		}
		else
		{
			textBox.PreviewTextInput -= TextBoxOnPreviewTextInput;
			textBox.PreviewKeyDown -= TextBoxOnPreviewKeyDown;
			textBox.GotFocus -= TextBoxOnGotFocus;
			textBox.LostFocus -= TextBoxOnLostFocus;
			textBox.Loaded -= TextBoxOnLoaded;
			DataObject.RemovePastingHandler(textBox, TextBoxOnPasting);
		}
	}

	private static void TextBoxOnLoaded(object sender, RoutedEventArgs eventArgs)
	{
		if (sender is TextBox textBox)
			FormatText(textBox);
	}

	private static void TextBoxOnGotFocus(object sender, RoutedEventArgs eventArgs)
	{
		if (sender is not TextBox textBox)
			return;

		if (int.TryParse(textBox.Text, NumberStyles.Integer | NumberStyles.AllowThousands, CultureInfo.CurrentCulture, out int value))
			textBox.Text = value.ToString(CultureInfo.CurrentCulture);
	}

	private static void TextBoxOnLostFocus(object sender, RoutedEventArgs eventArgs)
	{
		if (sender is TextBox textBox)
			FormatText(textBox);
	}

	private static void TextBoxOnPreviewTextInput(object sender, TextCompositionEventArgs eventArgs)
		=> eventArgs.Handled = NonDigitRegex.IsMatch(eventArgs.Text);

	private static void TextBoxOnPreviewKeyDown(object sender, KeyEventArgs eventArgs)
	{
		if (eventArgs.Key == Key.Space)
			eventArgs.Handled = true;
	}

	private static void TextBoxOnPasting(object sender, DataObjectPastingEventArgs eventArgs)
	{
		if (!eventArgs.DataObject.GetDataPresent(DataFormats.Text))
		{
			eventArgs.CancelCommand();
			return;
		}

		string text = (string)eventArgs.DataObject.GetData(DataFormats.Text);
		if (NonDigitRegex.IsMatch(text))
			eventArgs.CancelCommand();
	}

	private static void FormatText(TextBox textBox)
	{
		if (int.TryParse(textBox.Text, NumberStyles.Integer | NumberStyles.AllowThousands, CultureInfo.CurrentCulture, out int value))
			textBox.Text = value.ToString("N0", CultureInfo.CurrentCulture);
	}

	[GeneratedRegex("[^0-9]+")]
	private static partial Regex CreateNonDigitRegex();
}
