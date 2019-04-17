using System;
using System.Diagnostics;

namespace EventLoggerHoe
{
    public class WriteEntry
    {
        private readonly string _logName;
        private readonly int _eventId;

        public WriteEntry(string logName, int eventId)
        {
            _logName = logName;
            _eventId = eventId;
        }

        public void Log(Exception ex, EventLogEntryType type = EventLogEntryType.Error)
        {
            var message = string.Format("{0}\n\n{1}",
                ex.Message,
                ex.StackTrace);

            EventLog.WriteEntry(_logName, message, type, _eventId);
        }

        public void Log(string message)
        {
            EventLog.WriteEntry(_logName, message, EventLogEntryType.Information, _eventId);
        }
    }
}
