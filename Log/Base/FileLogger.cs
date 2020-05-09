using System;
using System.Diagnostics;
using System.IO;
using System.Threading;

namespace SchoolNetwork.Log.Base
{
    internal class FileLogger : ILogger
    {
        private readonly static Mutex mutex = new Mutex(false, @"SchoolNetWork/FileLogger");
        private readonly string logPath;

        public FileLogger(string logPath)
        {
            this.logPath = logPath+@"loginfo.log";
        }

        private void Write(string line)
        {
            try
            {
                mutex.WaitOne();
                if (!Directory.Exists(logPath)) Directory.CreateDirectory(logPath);
                FileInfo f = new FileInfo(logPath);
                if (f.Length > 1048576) { f.Delete(); f = new FileInfo(logPath); }
                using (var w = f.AppendText())
                {
                    var t = DateTime.UtcNow.ToString(@"yyyy-MM-dd HH:mm:ss.fff");
                    w.WriteLine($"{t} - {Process.GetCurrentProcess().ProcessName} - {line}");
                    w.Flush();
                }
            }
            catch (Exception exception)
            {
                Debug.WriteLine("写入文件日志发生错误：{0}", exception);
            }
            finally
            {
                mutex.ReleaseMutex();
            }
        }
        public void LogError(string error)
        {
            Write("error:" + error);
        }

        public void LogMessage(string message)
        {
            Write("message:" + message);

        }

        public void LogWarning(string warning)
        {
            Write("warning:" + warning);

        }
    }
}
