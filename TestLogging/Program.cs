using biz.dfch.CS.Commons.Diagnostics;
using System;
using System.Configuration;
using System.Diagnostics;
using System.Diagnostics.Contracts;



namespace TestLogging
{
    class Program
    {
        static void Main(string[] args)
        {
            //this is the Develop branch
            var traceSource = Logger.Get(TestLogging.Logging.Logging.TraceSourceName.TEST_LOGGING);

            traceSource.TraceEvent(TraceEventType.Start, (int)TestLogging.Logging.Logging.EventId.Start, "Started");

            traceSource.TraceEvent(TraceEventType.Stop, (int)TestLogging.Logging.Logging.EventId.Stop, "SUCCEEDED");
        }
    }
}
