namespace LoggingSystem.Library
{
    public class ConsoleLogger : ILogger
    {
        public void Write(LogLevel level, string message)
        {
            Console.WriteLine($"[{level}] - {message}");
        }
    }
}
