namespace LoggingSystem.Library
{
    public class DebugWindowLogger : ILogger
    {
        public void Write(LogLevel level, string message)
        {
            System.Diagnostics.Debug.WriteLine($"[{level}] - {message}");
        }
    }
}
