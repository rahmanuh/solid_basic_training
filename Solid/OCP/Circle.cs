using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.OCP
{
    // Bad example
    class Circle
    {
        public double Radius { get; set; }
    }

    // Good example
    public class Circle : Shape
    {
        public double Radius { get; set; }
        public override double Area()
        {
            Console.Write("Circle Area = ");
            Console.WriteLine(Radius * Radius * Math.PI);
            return Radius * Radius * Math.PI;
        }
    }
}
