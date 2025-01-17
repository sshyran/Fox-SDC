﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoxSDC_Server
{
    static class FoxEventLog
    {
        const string Title = "Fox SDC Server";
        public static void WriteEventLog(string Message, EventLogEntryType type)
        {
            if (EventLog.SourceExists(Title) == false)
            {
                EventLog.CreateEventSource(Title, "Application");
                return;
            }

            EventLog ev = new EventLog();
            ev.Source = Title;
            ev.WriteEntry(Message, type);
        }

        public static void RegisterEventLog()
        {
            if (EventLog.SourceExists(Title) == false)
            {
                EventLog.CreateEventSource(Title, "Application");
                Console.WriteLine(Title + " Created");
            }
            else
            {
                Console.WriteLine(Title + " Exists");
            }
        }

    }
}
