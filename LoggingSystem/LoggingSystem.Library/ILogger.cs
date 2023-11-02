namespace LoggingSystem.Library
{
    public interface ILogger
    {
        void Write(LogLevel level, string message);
    }
}
