namespace Roblox.TranslationResources;

/// <summary>
/// Locale resource factory
/// </summary>
public interface ILocaleResourceFactory
{
    /// <summary>
    /// Get resource by supported locale and translation resource state
    /// </summary>
    /// <param name="locale"><see cref="TranslationResourceLocale" /></param>
    /// <param name="state"><see cref="TranslationResourceState" /></param>
    /// <returns><see cref="IMasterResources" /></returns>
    IMasterResources GetMasterResources(TranslationResourceLocale locale, TranslationResourceState state);
}
