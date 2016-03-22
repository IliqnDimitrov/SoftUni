using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1.Point3D;

namespace _3.Paths
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Point3D point1 = new Point3D(10, 3, 1);
                Point3D point2 = new Point3D(5, 15, 3);
                Path3D path = new Path3D(point1, point2);

                Storage.SavePathToFile("D:\\SoftUni\\Fundamental level\\OOP\\2.Статични членове и пространства от имена\\Домашни\\Static Members and Namespaces\\path.txt", path.ToString());
                Console.WriteLine("Load from file:\n" + Storage.LoadPathFromFile("D:\\SoftUni\\Fundamental level\\OOP\\2.Статични членове и пространства от имена\\Домашни\\Static Members and Namespaces\\path.txt"));
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
