using System;

namespace P04_FillArrayByColumnsReverse
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] arrayOfNumbers = new int[4, 4];

            int counter = 1;
            for (int col = 0; col < arrayOfNumbers.GetLength(1); col += 2)
            {
                for (int row = 0; row < arrayOfNumbers.GetLength(0); row++)
                {
                    arrayOfNumbers[row, col] = counter;
                    counter++;
                }

                for (int row = arrayOfNumbers.GetLength(0) - 1; row >= 0; row--)
                {
                    arrayOfNumbers[row, col + 1] = counter;
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
