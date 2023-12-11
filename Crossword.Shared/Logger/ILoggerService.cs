namespace Crossword.Shared.Logger;

/// <summary>
/// Logging Interface
/// </summary>
public interface ILoggerService
{
    void LogInformation(string message);
    void LogWarning(string message);
    void LogError(Exception ex, string message);
    void LogVerbose(Exception ex, string message);
}
