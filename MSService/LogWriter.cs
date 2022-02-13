using System;
using System.Diagnostics;

namespace MSService {

    class LogWriter {

        const string LogName = "Managing Services Log Writer";
        const string LogSource = "Managing Services";

        public static void StartLog(string serviceName) {

            createLogIfNotExist();
            EventLog DemoLog = new EventLog(LogName);
            DemoLog.Source = LogSource;
            DemoLog.WriteEntry("Starting: " + serviceName, EventLogEntryType.Warning);
        }

        public static void StopLog(string serviceName) {

            createLogIfNotExist();
            EventLog DemoLog = new EventLog(LogName);
            DemoLog.Source = LogSource;
            DemoLog.WriteEntry("Stopping: " + serviceName, EventLogEntryType.Warning);
        }

        public static void createLogIfNotExist() {

            if (!EventLog.SourceExists(LogSource, ".")) {

                EventLog.CreateEventSource(LogSource, LogName);
            }
        }
    }
}
