namespace Issues.Inheritdoc;

/// <summary>
/// My service interface
/// </summary>
public interface IMyService
{
    /// <summary>
    /// Get a string value
    /// </summary>
    /// <param name="key">The key</param>
    /// <returns>The value</returns>
    string GetStringValue(string key);
}
