using System;
using System.Collections.Generic;
using System.Text;

class Exceptions
{
    public static T[] Subsequence<T>(T[] arr, int startIndex, int count)
    {
        if (arr == null)
        {
            throw new ArgumentNullException("You need to pass an array");
        }

        if (startIndex < 0 || startIndex > arr.Length)
        {
            throw new ArgumentOutOfRangeException("You can not pass an negative start index, or larger start index than arr.length");
        }

        if (count < 1 || count > arr.Length)
        {
            throw new ArgumentOutOfRangeException("You can not pass an negative count, or larger count than arr.length");
        }

        if ((startIndex + count) > arr.Length)
        {
            throw new IndexOutOfRangeException("You try to access more elements, than there exists in arr");
        }

        List<T> result = new List<T>();
        for (int i = startIndex; i < startIndex + count; i++)
        {
            result.Add(arr[i]);
        }
        return result.ToArray();
    }

    public static string ExtractEnding(string str, int count)
    {
        if (string.IsNullOrEmpty(str))
        {
            throw new ArgumentNullException("You can not pass null or empty string");
        }

        if (count < 0)
        {
            throw new ArgumentOutOfRangeException("You can not pass an negative count");
        }

        if (count > str.Length)
        {
            throw new ArgumentOutOfRangeException("Count can not be larger than " + str.Length);
        }

        StringBuilder result = new StringBuilder();
        for (int i = str.Length - count; i < str.Length; i++)
        {
            result.Append(str[i]);
        }
        return result.ToString();
    }

    public static bool CheckPrime(int number)
    {
        if (number <= 1)
        {
            return false;
        }

        for (int divisor = 2; divisor <= Math.Sqrt(number); divisor++)
        {
            if (number % divisor == 0)
            {
                return false;
            }
        }

        return true;
    }

    static void Main()
    {
        var substr = Subsequence("Hello!".ToCharArray(), 2, 3);
        Console.WriteLine(substr);

        var subarr = Subsequence(new int[] { -1, 3, 2, 1 }, 0, 2);
        Console.WriteLine(String.Join(" ", subarr));

        var allarr = Subsequence(new int[] { -1, 3, 2, 1 }, 0, 4);
        Console.WriteLine(String.Join(" ", allarr));

        //var emptyarr = Subsequence(new int[] { -1, 3, 2, 1 }, 0, 0);
        //Console.WriteLine(String.Join(" ", emptyarr));

        Console.WriteLine(ExtractEnding("I love C#", 2));
        Console.WriteLine(ExtractEnding("Nakov", 4));
        Console.WriteLine(ExtractEnding("beer", 4));
        //Console.WriteLine(ExtractEnding("Hi", 100));

        Console.WriteLine("23 is" + (CheckPrime(23) ? "" : " not") + " prime.");
        Console.WriteLine("33 is" + (CheckPrime(33) ? "" : " not") + " prime.");

        List<Exam> peterExams = new List<Exam>()
        {
            new SimpleMathExam(2),
            new CSharpExam(55),
            new CSharpExam(100),
            new SimpleMathExam(1),
            new CSharpExam(0),
        };
        Student peter = new Student("Peter", "Petrov", peterExams);
        double peterAverageResult = peter.CalcAverageExamResultInPercents();
        Console.WriteLine("Average results = {0:p0}", peterAverageResult);

    }
}
