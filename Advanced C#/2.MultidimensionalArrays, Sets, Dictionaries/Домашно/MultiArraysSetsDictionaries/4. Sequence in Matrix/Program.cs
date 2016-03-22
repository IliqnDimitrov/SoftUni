using System;
using System.Collections.Generic;
using System.Text;

class SequenceInMatrix
{
    static void Main()
    {
        Console.WriteLine("Please enter matrix rows:");
        int matrixRows = int.Parse(Console.ReadLine());
        Console.WriteLine("Please enter matrix cols:");
        int matrixCols = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter matrix: ");

        string[][] matrix = new string[matrixRows][];

        for (int i = 0; i < matrix.Length; i++)
        {
            string[] input = Console.ReadLine().Split();
            matrix[i] = new string[matrixCols];
            for (int j = 0; j < matrixCols; j++)
            {
                matrix[i][j] = input[j];
            }
        }

        int endIndexRow = 0;
        int endIndexCol = 0;
        int count = 1;
        int maxCount = 1;
        StringBuilder sequence = new StringBuilder();

        //check horizonatal
        for (int currentRow = 0; currentRow < matrixRows; currentRow++)
        {
            for (int currentCol = 0; currentCol < matrixCols - 1; currentCol++)
            {
                if (matrix[currentRow][currentCol] == matrix[currentRow][currentCol + 1])
                {
                    count++;
                }
                else
                {
                    count = 1;
                }
                if (maxCount < count)
                {
                    maxCount = count;
                    endIndexRow = currentRow;
                    endIndexCol = currentCol + 1;
                    sequence.Clear();
                    for (int i = 0; i < maxCount; i++)
                    {
                        sequence.AppendFormat("{0}, ",matrix[endIndexRow][endIndexCol]);
                    }
                }
            }
        }

        count = 1;
        //check vertical
        for (int currentCol = 0; currentCol < matrixCols; currentCol++)
        {
            for (int currentRow = 0; currentRow < matrixRows - 1; currentRow++)
            {
                if (matrix[currentRow][currentCol] == matrix[currentRow + 1][currentCol])
                {
                    count++;
                }
                else
                {
                    count = 1;
                }
                if (maxCount < count)
                {
                    maxCount = count;
                    endIndexRow = currentRow + 1;
                    endIndexCol = currentCol;
                    sequence.Clear();
                    for (int i = 0; i < maxCount; i++)
                    {
                        sequence.AppendFormat("{0}, ", matrix[endIndexRow][endIndexCol]);
                    }
                }

            }
        }

        count = 1;
        // diagonal left to right
        for (int currentRow = 0; currentRow < matrixRows - 1; currentRow++)
        {
            for (int currentCol = 0; currentCol < matrixCols - 1; currentCol++)
            {
                if (currentRow == matrixRows -1)
                {
                    break;
                }
                if (matrix[currentRow][currentCol] == matrix[currentRow + 1][currentCol + 1])
                {
                    count++;
                }
                else
                {
                    count = 1;
                }
                if (maxCount < count)
                {
                    maxCount = count;
                    endIndexRow = currentRow + 1;
                    endIndexCol = currentCol + 1;
                    sequence.Clear();
                    for (int i = 0; i < maxCount; i++)
                    {
                        sequence.AppendFormat("{0}, ", matrix[endIndexRow][endIndexCol]);
                    }
                }
                currentRow++;
            }
        }

        count = 1;
        //diagonal right to left
        for (int currentRow = 0; currentRow < matrixRows - 1; currentRow++)
        {
            for (int currentCol = matrixCols - 1; currentCol > 0; currentCol--)
            {
                if (currentRow == matrixRows - 1)
                {
                    break;
                }
                if (matrix[currentRow][currentCol] == matrix[currentRow + 1][currentCol - 1])
                {
                    count++;
                }
                else
                {
                    count = 1;
                }
                if (maxCount < count)
                {
                    maxCount = count;
                    endIndexRow = currentRow + 1;
                    endIndexCol = currentCol - 1;
                    sequence.Clear();
                    for (int i = 0; i < maxCount; i++)
                    {
                        sequence.AppendFormat("{0}, ", matrix[endIndexRow][endIndexCol]);
                    }
                }
                currentRow++;
            }
        }
        Console.WriteLine();
        Console.WriteLine("Longest sequence:");
        Console.WriteLine(sequence);
    }
}
