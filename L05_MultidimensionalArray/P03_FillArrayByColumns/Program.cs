using System;

namespace P03_FillArrayByColumns
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] arrayOfNumbers = new int[4, 4];

            int counter = 1;
            for (int col = 0; col < arrayOfNumbers.GetLength(1); col++)
            {
                for (int row = 0; row < arrayOfNumbers.GetLength(0); row++)
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
