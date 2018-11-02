using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.OCP
{
    // Bad Example
    class Rectangle
    {
        public double Height { get; set; }
        public double Width { get; set; }
    }

    // Good example
    public class Rectangle : Shape
    {
        public double Height { get; set; }
        public double Width { get; set; }
        public override double Area()
        {
            Console.Write("Rectangle Area = ");
            Console.WriteLine(Height * Width);
            return Height * Width;
        }
    }

}
