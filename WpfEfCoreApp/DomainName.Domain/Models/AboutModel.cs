using System.Diagnostics;

using DomainName.Domain.Interfaces.Models;
using DomainName.Domain.Models.Base;

namespace DomainName.Domain.Models;

/// <summary>
/// The about model.
/// </summary>
public sealed class AboutModel : ModelBase, IAboutModel
{
	private readonly FileVersionInfo _fileVersionInfo;

	/// <summary>
	/// Initializes an instance of <see cref="AboutModel"/> class.
	/// </summary>
	public AboutModel()
	{
		_fileVersionInfo = FileVersionInfo.GetVersionInfo(typeof(AboutModel).Assembly.Location);

		Title = _fileVersionInfo.ProductName;
		Version = _fileVersionInfo.FileVersion;
		Comments = _fileVersionInfo.Comments;
		Company = _fileVersionInfo.CompanyName;
		Copyright = _fileVersionInfo.LegalCopyright;
	}

	/// <inheritdoc/>
	public string? Title { get; }

	/// <inheritdoc/>
	public string? Version { get; }

	/// <inheritdoc/>
	public string? Comments { get; }

	/// <inheritdoc/>
	public string? Company { get; }

	/// <inheritdoc/>
	public string? Copyright { get; }
}
