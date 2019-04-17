using System;
using System.Diagnostics;
using EventLoggerHoe;

namespace EventLogger
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create log
            Console.WriteLine("What log would you like to create? (You need to run as `Administrator`)");
            var log = Console.ReadLine();

            if (!EventLog.SourceExists(log))
            {
                EventLog.CreateEventSource(log, log);
                Console.WriteLine("Creating log: {0}", log);
            }
            else
                Console.WriteLine("Log already exists: {0}", log);

            // Write to log ~ this is in `EventLoggerHoe.dll` so that it can easily be added to any solution
            var message = "Some debug message";
            new WriteEntry(log, 99).Log(message);

            Console.WriteLine("END: Sweet I wrote `{0}` to log {1}", message, log);
            Console.Read();
        }
    }
}
