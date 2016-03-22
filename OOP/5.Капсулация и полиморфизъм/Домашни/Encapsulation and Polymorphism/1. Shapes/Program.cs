using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Shapes
{
    class Program
    {
        static void Main(string[] args)
        {
            IShape[] shapes =
            {
                new Circle(4.5),
                new Rectangle(8, 1.4), 
                new Rhombus(6, 1.1), 
            };

            foreach (var shape in shapes)
            {
                Console.WriteLine(
                    "This is a {0} with area: {1:F2} and perimeter {2:F2}",
                    shape.GetType().Name,
                    shape.CalculateArea(),
                    shape.CalculatePerimeter());
            }

        }
    }
}
