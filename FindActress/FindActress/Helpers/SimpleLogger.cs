using System;
using System.Collections.Generic;
using System.Text;

namespace FindActress.Helpers
{
    public enum LogLevel
    {
        All = 0,        // All logs
        Debug = 1,      // Error, Warning, Info, Debug
        Info = 2,       // Error, Warning, Info
        Warning = 3,    // Error, Warning
        Error = 4       // Only Error
    }

    public class SimpleLogger
    {
        private static readonly Lazy<SimpleLogger> Implementation = new Lazy<SimpleLogger>(() => new SimpleLogger(), System.Threading.LazyThreadSafetyMode.PublicationOnly);

        public SimpleLogger()
        {
        }

        private readonly object _objectLock = new object();

        public LogLevel LogLevel { get; set; }

        public static SimpleLogger Current => Implementation.Value;

        private void Log(LogLevel level, string message, Exception exc = null)
        {
            var logText = string.Empty;
            logText = exc == null ? $"{level.ToString()} - {DateTime.UtcNow} - {message}" : $"{level.ToString()} - {DateTime.UtcNow} - {message}\n\tEXCEPTION: {exc.Message}\n\tSTACK TRACE: {(exc.StackTrace != null ? exc.StackTrace.ToString() : "")}";

            System.Console.WriteLine(logText);
        }

        public void Error(string message, Exception ex)
        {
            if (LogLevel > LogLevel.Error)
                return;

            lock (_objectLock)
            {
                Log(LogLevel.Error, message, ex);
            }
        }

        public void Debug(string message)
        {
            if (LogLevel > LogLevel.Debug)
                return;

            lock (_objectLock)
            {
                Log(LogLevel.Debug, message, null);
            }
        }
    }
}
