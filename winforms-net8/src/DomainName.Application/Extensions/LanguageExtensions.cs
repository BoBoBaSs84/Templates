using System.Globalization;

using DomainName.Domain.Enumerators;

namespace DomainName.Application.Extensions;

/// <summary>
/// Represents a static class that provides extension methods for the <see cref="Language"/> enumerator,
/// allowing for easy retrieval of culture information based on the language setting.
/// </summary>
public static class LanguageExtensions
{
	/// <summary>
	/// Retrieves the <see cref="CultureInfo"/> object corresponding to the specified <see cref="Language"/> enumerator value.
	/// </summary>
	/// <param name="language">The language enumerator value for which to retrieve the culture information.</param>
	/// <returns>The <see cref="CultureInfo"/> object that corresponds to the specified language.
	/// </returns>
	public static CultureInfo GetCultureInfo(this Language language)
		=> CultureInfo.GetCultureInfo(language.GetShortName());
}
