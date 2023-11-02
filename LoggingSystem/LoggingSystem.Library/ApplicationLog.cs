using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoggingSystem.Library
{
    public static class ApplicationLog
    {
        private static ILogger currentLogger = null;

        public static void Initialize(ILogger logger)
        {
            ApplicationLog.currentLogger = logger;
        }

        public static void Write(LogLevel level, string message)
        {
            if (currentLogger is not null)
            {
                currentLogger.Write(level, message);
            }
        }
    }
}
