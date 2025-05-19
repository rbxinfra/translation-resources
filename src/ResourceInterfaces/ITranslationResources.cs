namespace Roblox.TranslationResources;

using System.Collections.Generic;

/// <summary>
/// Interface for translated resources.
/// </summary>
public interface ITranslationResources
{
    /// <summary>
    /// Get all keys for translated resources.
    /// </summary>
    /// <returns>Dictionary of key and values</returns>
    IReadOnlyDictionary<string, string> GetAllKeys();

    /// <summary>
    /// Get full namespace
    /// </summary>
    /// <returns>full namespace where resource is.</returns>
    string GetFullContentNamespaceName();

    /// <summary>
    /// Get state of translated resources.
    /// </summary>
    /// <returns><see cref="TranslationResourceState" /></returns>
    TranslationResourceState State { get; }
}
