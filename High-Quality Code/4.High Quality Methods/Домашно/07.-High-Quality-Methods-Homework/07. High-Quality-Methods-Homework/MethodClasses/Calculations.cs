//-----------------------------------------------------------------------
// <copyright file="Calculations.cs" company="ilqkaCompany">
//     Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------
namespace Methods.MethodClasses
{
    using System;

    /// <summary>
    /// The class make calculations.
    /// </summary>
    public static class Calculations
    {
        /// <summary>
        /// The method calculate triangle area.
        /// </summary>
        /// <param name="a">
        /// The side a of the triangle.
        /// </param>
        /// <param name="b">
        /// The side b of the triangle.
        /// </param>
        /// <param name="c">
        /// The side c of the triangle.
        /// </param>
        /// <returns>
        /// The area of triangle a,b,c.
        /// </returns>
        public static double CalcTriangleArea(double a, double b, double c)
        {
            if (a <= 0 || b <= 0 || c <= 0)
            {
                throw new ArgumentException("Sides should be positive.");
            }

            double s = (a + b + c) / 2;
            double area = Math.Sqrt(s * (s - a) * (s - b) * (s - c));
            return area;
        }

        /// <summary>
        /// The method find max number in array of elements.
        /// </summary>
        /// <param name="elements">
        /// The array elements.
        /// </param>
        /// <returns>
        /// Max integer in array elements.
        /// </returns>
        public static int FindMax(params int[] elements)
        {
            if (elements == null || elements.Length == 0)
            {
                throw new ArgumentNullException("elements", "The input array is empty.");
            }

            for (int i = 1; i < elements.Length; i++)
            {
                if (elements[i] > elements[0])
                {
                    elements[0] = elements[i];
                }
            }

            return elements[0];
        }

        /// <summary>
        /// The method calculate the distance between points.
        /// </summary>
        /// <param name="x1">
        /// The point x1.
        /// </param>
        /// <param name="y1">
        /// The point y1.
        /// </param>
        /// <param name="x2">
        /// The point x2.
        /// </param>
        /// <param name="y2">
        /// The point y2.
        /// </param>
        /// <returns>
        /// Distance between points.
        /// </returns>
        public static double CalcDistance(double x1, double y1, double x2, double y2)
        {
            double distance = Math.Sqrt(((x2 - x1) * (x2 - x1)) + ((y2 - y1) * (y2 - y1)));
            return distance;
        }

        /// <summary>
        /// Checks if the line crossing the two given points is horizontal.
        /// </summary>
        /// <param name="x1">
        /// The first point.
        /// </param>
        /// <param name="x2">
        /// The second point.
        /// </param>
        /// <returns>
        /// The <see cref="bool"/>
        /// </returns>
        public static bool IsHorizontal(double x1, double x2)
        {
            return x1 == x2;
        }

        /// <summary>
        /// Checks if the line crossing the two given points is vertical.
        /// </summary>
        /// <param name="y1">
        /// The first point.
        /// </param>
        /// <param name="y2">
        /// The second point.
        /// </param>
        /// <returns>
        /// The <see cref="bool"/>
        /// </returns>
        public static bool IsVertical(double y1, double y2)
        {
            return y1 == y2;
        }
    }
}