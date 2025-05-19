namespace Roblox.TranslationResources;

/// <summary>
/// Base class for all resource implementation classes.
/// </summary>
public class TranslationResourcesBase
{
    /// <summary>
    /// Initializes a new instance of the <see cref="TranslationResourcesBase" /> class.
    /// </summary>
    /// <param name="state">State of translated resources.</param>
    protected TranslationResourcesBase(TranslationResourceState state)
    {
        State = state;
    }

    /// <summary>
    /// Get state of translated resources.
    /// </summary>
    /// <returns><see cref="TranslationResourceState" /></returns>  
    public TranslationResourceState State { get; }
}
