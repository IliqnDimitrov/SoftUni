using System;

public class LargerThanNeighbours
{
    static void Main()
    {
        // input
        int[] numbers = { 1, 3, 4, 5, 1, 0, 5 };

        // invoking the method
        for (int i = 0; i < numbers.Length; i++)
        {
            Console.WriteLine(IsLargerThanNeighbors(numbers, i));
        }
    }

    public static bool IsLargerThanNeighbors(int[] nums, int i)
    {
        bool isLarger = false;

        if (i == 0)
        {
            isLarger = nums[i + 1] < nums[i];
        }
        else if (i > 0 && i < nums.Length - 1)
        {
            isLarger = nums[i - 1] < nums[i] && nums[i + 1] < nums[i];
        }
        else
        {
            isLarger = nums[i - 1] < nums[i];
        }

        return isLarger;
    }
}
