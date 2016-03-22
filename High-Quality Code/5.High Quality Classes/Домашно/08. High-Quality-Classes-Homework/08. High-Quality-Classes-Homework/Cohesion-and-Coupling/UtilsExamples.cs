namespace CohesionAndCoupling
{
    using System;
    using CohesionAndCoupling.Utils;

    class UtilsExamples
    {
        static void Main()
        {
            Console.WriteLine(FlieUtils.GetFileExtension("example"));
            Console.WriteLine(FlieUtils.GetFileExtension("example.pdf"));
            Console.WriteLine(FlieUtils.GetFileExtension("example.new.pdf"));

            Console.WriteLine(FlieUtils.GetFileNameWithoutExtension("example"));
            Console.WriteLine(FlieUtils.GetFileNameWithoutExtension("example.pdf"));
            Console.WriteLine(FlieUtils.GetFileNameWithoutExtension("example.new.pdf"));

            Console.WriteLine("Distance in the 2D space = {0:f2}",
                CalculateDistanceUtils.CalcDistance2D(1, -2, 3, 4));
            Console.WriteLine("Distance in the 3D space = {0:f2}",
                CalculateDistanceUtils.CalcDistance3D(5, 2, -1, 3, -6, 4));

            Parallelepiped parallelepiped = new Parallelepiped(3,4,5);
            Console.WriteLine("Volume = {0:f2}", parallelepiped.CalcVolume());
            Console.WriteLine("Diagonal XYZ = {0:f2}", parallelepiped.CalcDiagonalXYZ());
            Console.WriteLine("Diagonal XY = {0:f2}", parallelepiped.CalcDiagonalXY());
            Console.WriteLine("Diagonal XZ = {0:f2}", parallelepiped.CalcDiagonalXZ());
            Console.WriteLine("Diagonal YZ = {0:f2}", parallelepiped.CalcDiagonalYZ());
        }
    }
}
