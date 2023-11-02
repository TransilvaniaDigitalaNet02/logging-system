namespace LoggingSystem.Library
{
    public class FileLogger : ILogger
    {
        public void Write(LogLevel level, string message)
        {
            string fileName = $"Log-{DateTime.Today:yyyy-MM-dd}.txt";

            // v1
            // string pathToLogFile = Path.Combine(Directory, fileName);

            string pathToDir = Path.Combine(
                Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData),
                "LoggingSystem");

            if (!Directory.Exists(pathToDir))
            {
                Directory.CreateDirectory(pathToDir);
            }

            string pathToLogFile = Path.Combine(
                pathToDir,
                fileName);

            string content = $"[{DateTime.Now:HH:mm:ss:ffff}] [{level}] - {message}" + Environment.NewLine;

            File.AppendAllText(pathToLogFile, content);
        }
    }
}
