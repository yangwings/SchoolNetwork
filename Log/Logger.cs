using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolNetwork.Log
{
    /// <summary>
    /// 日志输出方式 
    /// </summary>
    [Flags]
    public enum LoggingMode
    {
        /// <summary>
        /// 不输出日志
        /// </summary>
        Disabled = 0,

        /// <summary>
        /// Debug输出
        /// </summary>
        Debug = 1,

        /// <summary>
        /// 日志输出到Windows事件查看器
        /// </summary>
        EventLog = 2,

        /// <summary>
        /// 日志输出到文件
        /// </summary>
        File = 4
    }

    internal static class Logger
    {
        private static readonly List<Base.ILogger> Loggers = new List<Base.ILogger>();
        static Logger()
        {
            var config = Config.Configuration.Config;
            if(config.LoggingMode.HasFlag(LoggingMode.Debug)) Loggers.Add(new Base.DebugLogger());
            if (config.LoggingMode.HasFlag(LoggingMode.EventLog)) Loggers.Add(new Base.EventLogger());
            if (config.LoggingMode.HasFlag(LoggingMode.File)) Loggers.Add(new Base.FileLogger(config.LogPath));
        }
        public static void Log(string message)
        {
            Loggers.ForEach(l => l.LogMessage(message));
        }
        public static void Error(string error,Exception exception=null)
        {
            Loggers.ForEach(l =>
            {
                l.LogError(error);
                if (exception != null) l.LogError(exception.ToString());
            });
            
        }
    }
}
