using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.OCP
{
    public class Triangle : Shape
    {
        public double height { get; set; }
        public double width { get; set; }
        public override double Area()
        {
            Console.Write("Triangle Area = ");
            Console.WriteLine(height * width * 0.5);
            return height * width * 0.5;
        }
    }
}
