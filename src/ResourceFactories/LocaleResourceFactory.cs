namespace Roblox.TranslationResources;

using System.Collections.Concurrent;

/// <summary>
/// Resource factory get resources.
/// </summary>
public class LocaleResourceFactory : ILocaleResourceFactory
{
    private readonly ConcurrentDictionary<(TranslationResourceLocale, TranslationResourceState), IMasterResources> _MasterResources;

    /// <summary>
    /// Construct a new instance of <see cref="LocaleResourceFactory"/>
    /// </summary>
    public LocaleResourceFactory()
    {
        _MasterResources = new();
    }

    /// <inheritdoc cref="ILocaleResourceFactory.GetMasterResources(TranslationResourceLocale, TranslationResourceState)"/>
    public IMasterResources GetMasterResources(TranslationResourceLocale locale, TranslationResourceState state)
    {
        return _MasterResources.GetOrAdd((locale, state), key => CreateMasterResources(key.Item1, key.Item2));
    }

    private IMasterResources CreateMasterResources(TranslationResourceLocale supportedLocaleEnum, TranslationResourceState translationResourceState) 
        => new MasterResources(supportedLocaleEnum, translationResourceState);
}
