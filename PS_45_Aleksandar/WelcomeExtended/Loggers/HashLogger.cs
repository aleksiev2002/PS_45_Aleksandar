using Microsoft.Extensions.Logging;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WelcomeExtended.Loggers
{
    internal class HashLogger: ILogger
    {
        private readonly ConcurrentDictionary<int, string> _logMessages;
        private readonly string _name;

        public HashLogger(string name)
        {
            _logMessages = new ConcurrentDictionary<int, string>();
            _name = name;
        }
    }
}
