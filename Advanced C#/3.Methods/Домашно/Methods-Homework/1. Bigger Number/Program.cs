using System;

class BiggerNumber
{
    static void Main()
    {
        // input
        Console.WriteLine("Please enter two numbers, each on a separate line.\nInput:");
        int firstNumber = int.Parse(Console.ReadLine());
        int secondNumber = int.Parse(Console.ReadLine());

        //invoking the method
        int max = GetMax(firstNumber, secondNumber);

        //output
        Console.WriteLine("Output:");
        Console.WriteLine(max);
    }

    private static int GetMax(int a, int b)
    {
        int maxNum = (a > b) ? a : b;
        return maxNum;
    }
}
