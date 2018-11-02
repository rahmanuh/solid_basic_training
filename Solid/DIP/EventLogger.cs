using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.DIP
{
    public class EventLogger : ILogger
    {
        public void LogMessage(string aMessage)
        {
            Console.WriteLine("This is a message from LogMessage method in EventLogger class");
        }
    }
}
