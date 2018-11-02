using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.ISP
{
    public class Programmer: IProgrammer
    {
        public void WorkOnTask()
        {
            Console.WriteLine("Programmer writes some codes");
        }
    }
}
