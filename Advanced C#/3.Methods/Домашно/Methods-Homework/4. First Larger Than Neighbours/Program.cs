using System;

class FirstLargerThanNeighbours
{
    static void Main()
    {
        // input
        int[] sequenceOne = { 1, 3, 4, 5, 1, 0, 5 };
        int[] sequenceTwo = { 1, 2, 3, 4, 5, 6, 6 };
        int[] sequenceThree = { 1, 1, 1 };

        // invoking the method
        Console.WriteLine(IndexOfFirstElementLargerThanNeighbours(sequenceOne));
        Console.WriteLine(IndexOfFirstElementLargerThanNeighbours(sequenceTwo));
        Console.WriteLine(IndexOfFirstElementLargerThanNeighbours(sequenceThree));
    }

    private static int IndexOfFirstElementLargerThanNeighbours(int[] seq)
    {
        for (int i = 0; i < seq.Length; i++)
        {
            if (LargerThanNeighbours.IsLargerThanNeighbors(seq, i)) // invoking the method from project 03. Larger-Than-Neighbours
            {
                return i;
            }
        }
        return -1;
    }
   
}
