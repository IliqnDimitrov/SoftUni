//-----------------------------------------------------------------------
// <copyright file="MainMethods.cs" company="ilqkaCompany">
//     Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------
namespace Methods
{
    using System;
    using MethodClasses;

    /// <summary>
    /// This is Main class.
    /// </summary>
    public class MainMethods
    {   
        /// <summary>
        /// This is Main method.
        /// </summary>
        public static void Main()
        {
            try
            {
                Console.WriteLine("Triangle area = {0}", Calculations.CalcTriangleArea(3, 4, 5));
            }
            catch (Exception e)
            {
                 Console.Error.WriteLine(e.Message);
            }

            try
            {
                Console.WriteLine("The name of digis is {0}", Formatting.NumberToDigit(5));
            }
            catch (Exception e)
            {
                Console.Error.WriteLine(e.Message);     
            }

            try
            {
                Console.WriteLine("The max element of array is {0}", Calculations.FindMax(5, -1, 3, 2, 14, 2, 3));
            }
            catch (Exception e)
            {
                Console.Error.WriteLine(e.Message);
            }
            
            Console.WriteLine(Formatting.PrintAsNumber(1.3, "f"));
            Console.WriteLine(Formatting.PrintAsNumber(0.75, "%"));
            Console.WriteLine(Formatting.PrintAsNumber(2.30, "r"));

            Console.WriteLine("The distance between the two points is {0}", Calculations.CalcDistance(3, -1, 3, 2.5));
            Console.WriteLine("Horizontal? " + Calculations.IsHorizontal(3, 3));
            Console.WriteLine("Vertical? " + Calculations.IsVertical(-1, 2.5));

            Student peter = new Student("Peter", "Ivanov");
            peter.AditionalInfo = "From Sofia, born at 17.03.1992";

            Student stella = new Student("Stella", "Markova");
            stella.AditionalInfo = "From Vidin, gamer, high results, born at 03.11.1993";

            try
            {
                Console.WriteLine(
                    "{0} older than {1} -> {2}",
                    peter.FirstName,
                    stella.FirstName,
                    peter.IsOlderThan(stella));
            }
            catch (Exception e)
            {
               Console.Error.WriteLine(e.Message);
            }
        }
    }
}