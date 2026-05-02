using System.Diagnostics.CodeAnalysis;

using DomainName.Application.Abstractions.Presentation.Services;

using Microsoft.Win32;

namespace DomainName.Presentation.Services;

/// <summary>
/// The file and folder dialog service class.
/// </summary>
[ExcludeFromCodeCoverage(Justification = "This class wraps WPF file dialogs which require a UI thread.")]
internal sealed class FileDialogService : IFileDialogService
{
	/// <inheritdoc/>
	public string? ShowOpenFileDialog(string filter, string title)
	{
		OpenFileDialog dialog = new()
		{
			Filter = filter,
			Title = title
		};

		bool? result = dialog.ShowDialog();

		return result == true ? dialog.FileName : null;
	}

	/// <inheritdoc/>
	public string? ShowSaveFileDialog(string filter, string title, string? defaultFileName = null)
	{
		SaveFileDialog dialog = new()
		{
			Filter = filter,
			Title = title,
			FileName = defaultFileName ?? string.Empty
		};

		bool? result = dialog.ShowDialog();

		return result == true ? dialog.FileName : null;
	}

	/// <inheritdoc/>
	public string? ShowSelectFolderDialog(string title)
	{
		OpenFolderDialog dialog = new()
		{
			Title = title,
			Multiselect = false
		};

		bool? result = dialog.ShowDialog();

		return result == true ? dialog.FolderName : null;
	}

	/// <inheritdoc/>
	public string[] ShowSelectFoldersDialog(string title)
	{
		OpenFolderDialog dialog = new()
		{
			Title = title,
			Multiselect = true
		};

		bool? result = dialog.ShowDialog();

		return result == true ? dialog.FolderNames : [];
	}
}
