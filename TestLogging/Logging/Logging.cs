using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestLogging.Logging
{
    class Logging
    {
        public enum EventId
        {
            Default = 0,

            Stop = int.MaxValue - 2,
            Start = int.MaxValue - 1,

            Exception = int.MaxValue
        }

        public static class TraceSourceName
        {
            public const string TEST_LOGGING = "TestLogging";
        }
    }
}
