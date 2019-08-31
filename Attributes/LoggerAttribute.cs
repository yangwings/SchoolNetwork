using SchoolNetwork.Log;
using System;

namespace SchoolNetwork.Attributes
{
    [AttributeUsage(AttributeTargets.Class, Inherited = false, AllowMultiple = false)]
    public sealed class LoggerAttribute : Attribute
    {
        private LoggingMode Mode { get; set; }
        private string LogPath { get; set; }
        public LoggerAttribute(LoggingMode mode = LoggingMode.Disabled, string logPath = @"./Login/")
        {
            Mode = mode;
            LogPath = logPath;
        }

    }
}
