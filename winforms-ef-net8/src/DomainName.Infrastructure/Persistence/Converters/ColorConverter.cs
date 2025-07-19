using System.Drawing;

using BB84.Extensions;

using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DomainName.Infrastructure.Persistence.Converters;

/// <summary>
/// Represents a value converter for converting <see cref="Color"/> to and from a byte array.
/// </summary>
internal sealed class ColorConverter : ValueConverter<Color, byte[]>
{
	/// <summary>
	/// Initializes a new instance of the <see cref="ColorConverter"/> class.
	/// </summary>
	public ColorConverter() : base(v => v.ToRgbByteArray(), v => v.FromArgbByteArray())
	{ }
}
