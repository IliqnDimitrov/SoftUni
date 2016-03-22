//-----------------------------------------------------------------------
// <copyright file="Formatting.cs" company="ilqkaCompany">
//     Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------
namespace Methods.MethodClasses
{
    using System;

    /// <summary>
    /// The class formatting numbers.
    /// </summary>
    public static class Formatting
    {
        /// <summary>
        /// The method print the input format.
        /// </summary>
        /// <param name="number">
        /// The number.
        /// </param>
        /// <param name="format">
        /// The format of number.
        /// </param>
        /// <returns>
        /// The <see cref="string"/>
        /// </returns>
        public static string PrintAsNumber(object number, string format)
        {
            string formatString = format.ToLower();
            switch (formatString)
            {
                case "f":
                    return string.Format("{0:f2}", number);
                case "%":
                    return string.Format("{0:p0}", number);
                case "r":
                    return string.Format("{0,8}", number);
            }

            throw new ArgumentException("Wrong format string", "format");
        }

        /// <summary>
        /// The method convert integer to string.
        /// </summary>
        /// <param name="number">
        /// The number for convert.
        /// </param>
        /// <returns>
        /// The <see cref="string"/>
        /// </returns>
        public static string NumberToDigit(int number)
        {   
            switch (number)
            {
                case 0:
                    return "zero";
                case 1:
                    return "one";
                case 2:
                    return "two";
                case 3:
                    return "three";
                case 4:
                    return "four";
                case 5:
                    return "five";
                case 6: 
                    return "six";
                case 7:
                    return "seven";
                case 8: 
                    return "eight";
                case 9: 
                    return "nine";
            }

            return "Invalid number!,should be in the range [0..9]";
        }
    }
}