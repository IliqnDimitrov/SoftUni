using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1.Point3D;


namespace _2.Distance_Calculator
{
    static class DistanceCalculator
    {
        public static void CalculateTheDistance(Point3D one, Point3D two)
        {
            double deltaX = two.X - one.X;
            double deltaY = two.Y - one.Y;
            double deltaZ = two.Z - one.Z;

            double distance = (double)Math.Sqrt(deltaX * deltaX + deltaY * deltaY + deltaZ * deltaZ);
            Console.WriteLine("The distance between the two points is: {0}",distance);
        }
    }
}
