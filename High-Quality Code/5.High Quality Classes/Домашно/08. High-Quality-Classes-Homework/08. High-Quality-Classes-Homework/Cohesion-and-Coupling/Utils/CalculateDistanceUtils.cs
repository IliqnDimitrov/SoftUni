namespace CohesionAndCoupling.Utils
{
    using System;

    /// <summary>
    /// Class that calculate distance in
    /// 2D and 3D coordinate system
    /// </summary>
    static class CalculateDistanceUtils
    {
        /// <summary>
        /// Calculate distance in 2D
        /// coordinate system for points
        /// A and B
        /// </summary>
        /// <param name="x1">
        /// X coordinate for point A
        /// </param>
        /// <param name="y1">
        /// Y coordinate for point A
        /// </param>
        /// <param name="x2">
        /// X coordinate for point B
        /// </param>
        /// <param name="y2">
        /// Y coordinate for point B
        /// </param>
        /// <returns>
        /// Floating point value of
        /// distance between A and B
        /// </returns>
        public static double CalcDistance2D(double x1, double y1, double x2, double y2)
        {
            double distance = Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1));
            return distance;
        }

        /// <summary>
        /// Calculates distance in 3D
        /// coordinate system between 
        /// points A and B
        /// </summary>
        /// <param name="x1">
        /// X coordinate for point A
        /// </param>
        /// <param name="y1">
        /// Y coordinate for point A
        /// </param>
        /// <param name="z1">
        /// Z coordinate for point A
        /// </param>
        /// <param name="x2">
        /// X coordinate for point B
        /// </param>
        /// <param name="y2">
        /// Y coordinate for point B
        /// </param>
        /// <param name="z2">
        /// Z coordinate for point B
        /// </param>
        /// <returns>
        /// Floating point value of 
        /// distance between A and B
        /// </returns>
        public static double CalcDistance3D(double x1, double y1, double z1, double x2, double y2, double z2)
        {
            double distance = Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1) + (z2 - z1) * (z2 - z1));
            return distance;
        }
    }
}