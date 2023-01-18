namespace Issues.Inheritdoc;

/// <inheritdoc />
public class MyService : IMyService
{
    public string GetStringValue(string key) => $"{key}itlan";
}
