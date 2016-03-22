using System;
using System.Data;
using System.Linq;

class CollectTheCoins
{
    private static void Main()
    {
        string[][] board = new string[4][];
        for (int i = 0; i < board.Length; i++)
        {
            string input = Console.ReadLine();
            board[i] = new string[input.Length];
            for (int j = 0; j < input.Length; j++)
            {
                board[i][j] = input[j].ToString();
            }
        }
        int currentRow = 0;
        int currentCol = 0;
        int coinCollected = 0;
        int wallHit = 0;

        char[] inputCommands = Console.ReadLine().ToCharArray();
        for (int currentCommand = 0; currentCommand < inputCommands.Length; currentCommand++)
        {
            if (inputCommands[currentCommand].ToString() == "V")
            {
                currentRow++;
                try
                {
                    coinCollected = CoinCollected(board, currentRow, currentCol, coinCollected);
                }
                catch (IndexOutOfRangeException)
                {
                    currentRow--;
                    wallHit++;
                }               
            }
            if (inputCommands[currentCommand].ToString() == ">")
            {
                currentCol++;
                try
                {
                    coinCollected = CoinCollected(board, currentRow, currentCol, coinCollected);
                }
                catch (IndexOutOfRangeException)
                {
                    currentCol--;
                    wallHit++;
                }              
            }
            if (inputCommands[currentCommand].ToString() == "<")
            {
                currentCol--;
                try
                {
                    coinCollected = CoinCollected(board, currentRow, currentCol, coinCollected);
                }
                catch (IndexOutOfRangeException)
                {
                    currentCol++;
                    wallHit++;
                }             
            }
            if (inputCommands[currentCommand].ToString() == "^")
            {
                currentRow--;
                try
                {
                    coinCollected = CoinCollected(board, currentRow, currentCol, coinCollected);
                }
                catch (IndexOutOfRangeException)
                {
                    currentRow++;
                    wallHit++;
                }                
            }
        }
        Console.WriteLine();
        Console.WriteLine("Coins collected: {0} \n\nWalls hit: {1}", coinCollected, wallHit);
    }

    private static int CoinCollected(string[][] board, int currentRow, int currentCol, int coinCollected)
    {
        if (board[currentRow][currentCol] == "$")
        {
            coinCollected++;
        }
        return coinCollected;
    }
}
