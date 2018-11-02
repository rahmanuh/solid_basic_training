using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.ISP
{
    // Bad example
    public class TeamLead : ILead
    {
        public void AssignTask()
        {
            Console.WriteLine("Team lead assign task");
        }
        public void CreateSubTask()
        {
            Console.WriteLine("Team lead create sub task");
        }
        public void WorkOnTask()
        {
            Console.WriteLine("Team lead can also work on task");
        }
    }


    // Good example
    //public class TeamLead : IProgrammer, ILead
    //{
    //    public void AssignTask()
    //    {
    //        Console.WriteLine("Team lead assign task");
    //    }
    //    public void CreateSubTask()
    //    {
    //        Console.WriteLine("Team lead create sub task");
    //    }
    //    public void WorkOnTask()
    //    {
    //        Console.WriteLine("Team lead can also work on task");
    //    }
    //}

    
}
