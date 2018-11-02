using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.DIP
{
    // Bad example
    public class DbLogger
    {
        public void LogMessage(string aMessage)
        {
            Console.WriteLine("This is a message from LogMessage method in DbLogger class");
        }
    }

    // Good example
    //public class DbLogger : ILogger
    //{
    //    public void LogMessage(string aMessage)
    //    {
    //        //Code to write message in database.  
    //    }
    //}
}
