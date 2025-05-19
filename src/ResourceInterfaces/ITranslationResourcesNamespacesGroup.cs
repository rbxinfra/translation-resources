namespace Roblox.TranslationResources;

using System;

/// <summary>
/// A translation namespace.
/// </summary>
public interface ITranslationResourcesNamespacesGroup
{
    /// <summary>
    /// Gets an <see cref="ITranslationResources" /> by full namespace string.
    /// </summary>
    /// <param name="fullTranslationResourceNamespace">The full translation resource namespace.</param>
    /// <returns>An <see cref="ITranslationResources" /> (or <c>null</c> if it does not exist in the this <see cref="ITranslationResourcesNamespacesGroup" />.)</returns>
    /// <exception cref="ArgumentException"><paramref name="fullTranslationResourceNamespace" /> is null or whitespace.</exception>
    ITranslationResources GetByFullNamespace(string fullTranslationResourceNamespace);
}
