using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1.Point3D;

namespace _2.Distance_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Point3D one = new Point3D(-7, -4, 3);
            Point3D two = new Point3D(17, 6, 2.5);

            DistanceCalculator.CalculateTheDistance(one, two);
        }
    }
}
