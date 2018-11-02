using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.ISP
{

    // Bad example
    public class Manager : ILead
    {
        public void AssignTask()
        {
            Console.WriteLine("Manager assign task");
        }
        public void CreateSubTask()
        {
            Console.WriteLine("Manager create sub task");
        }
        public void WorkOnTask()
        {
            throw new Exception("Manager can't work on Task");
        }
    }

    // Good example
    public class Manager : ILead
    {
        public void AssignTask()
        {
            Console.WriteLine("Manager assign task");
        }
        public void CreateSubTask()
        {
            Console.WriteLine("Manager create sub task");
        }
    }


}
