using System;

namespace P02_FillArrayInNormalWay
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] arrayOfNumbers = new int[4, 4];

            int counter = 1;
            for (int row = 0; row < arrayOfNumbers.GetLength(0); row++)
            {
                for (int col = 0; col < arrayOfNumbers.GetLength(1); col++)
                {
                    arrayOfNumbers[row, col] = counter;
                    counter++;
                }
            }

            for (int row = 0; row < arrayOfNumbers.GetLength(0); row++)
            {
                for (int col = 0; col < arrayOfNumbers.GetLength(1); col++)
                {
                    Console.Write(arrayOfNumbers[row, col] + " ");
                }

                Console.WriteLine();
            }
        }
    }
}
