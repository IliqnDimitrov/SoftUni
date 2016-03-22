using System;
using System.Linq;

class Program
{
    static void Main()
    {
        // input
        double inputNum = double.Parse(Console.ReadLine());

        // output
        double reversed = GetReversedNumber(inputNum);
        Console.WriteLine(reversed);
    }

    private static double GetReversedNumber(double inputNum)
    {
        bool isNegative = inputNum < 0;
        string input = string.Join("", inputNum.ToString().TrimStart('-').Reverse());
        double number = double.Parse(input);
        return isNegative ? -number : number;
    }
}