namespace LoggingSystem.Library
{
    public class FileLogger : ILogger
    {
        public FileLogger(string directory)
        {
            if (directory is null)
            {
                throw new ArgumentNullException(nameof(directory));
            }

            if (string.IsNullOrEmpty(directory))
            {
                throw new ArgumentException("Path must not be empty.", nameof(directory));
            }

            if (!Path.Exists(directory))
            {
                throw new DirectoryNotFoundException($"Directory '{directory}' was not found.");
            }

            Directory = directory;
        }

        public string Directory { get; }

        public void Write(LogLevel level, string message)
        {
            string fileName = $"Log-{DateTime.Today:yyyy-MM-dd}.txt";
            string pathToLogFile = Path.Combine(Directory, fileName);
            string content = $"[{level}] - {message}" + Environment.NewLine;

            File.AppendAllText(pathToLogFile, content);
        }
    }
}
