using System.Diagnostics;

namespace SchoolNetwork.Log.Base
{
    internal class EventLogger : ILogger
    {
        private readonly bool source = false;
        private const string EventLog_Source = @"SchoolNetwork";
        public EventLogger()
        {
            if (!EventLog.SourceExists(EventLog_Source)) EventLog.CreateEventSource("SchoolNetwork", "应用程序");
            source = true;
        }

        public void LogError(string error)
        {
            if (!source) EventLog.WriteEntry(EventLog_Source, error, EventLogEntryType.Error);
        }

        public void LogMessage(string message)
        {
            if (!source) EventLog.WriteEntry(EventLog_Source, message, EventLogEntryType.Information);
        }

        public void LogWarning(string warning)
        {
            if (!source) EventLog.WriteEntry(EventLog_Source, warning, EventLogEntryType.Warning);
        }
    }
}
