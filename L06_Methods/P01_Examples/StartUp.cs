namespace P01_Examples
{
    using System;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            //// ================================================================= //
            //int lengthOfArray = int.Parse(Console.ReadLine());
            //int[] array = new int[lengthOfArray];

            //for (int index = 0; index < array.Length; index++)
            //{
            //    int number = int.Parse(Console.ReadLine());

            //    array[index] = number;
            //}

            //PrintOneDimensionalArrayWithForLoop(array);

            //// ================================================================= //
            //int[] arrayFromNumbers = Console.ReadLine()
            //    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
            //    .Select(int.Parse)
            //    .ToArray();

            //PrintOneDimensionalArrayWithForLoop(arrayFromNumbers); 
            //// ================================================================= //
            //int[] arr = { 1, 2, 3, 4, 5, 6 };

            // ================================================================= //
            int lengthOfTwoDimensionalArray = int.Parse(Console.ReadLine());
            int[,] twoDimensionalArrayOfNumbersWithForLoop
                = new int[lengthOfTwoDimensionalArray, lengthOfTwoDimensionalArray];

            for (int row = 0; row < twoDimensionalArrayOfNumbersWithForLoop.GetLength(0); row++)
            {
                for (int col = 0; col < twoDimensionalArrayOfNumbersWithForLoop.GetLength(1); col++)
                {
                    Console.Write($"[{row}, {col}] = ");
                    int number = int.Parse(Console.ReadLine());

                    twoDimensionalArrayOfNumbersWithForLoop[row, col] = number;
                }

                Console.WriteLine();
            }

            PrintArrayWithForLoop(twoDimensionalArrayOfNumbersWithForLoop);
        }

        private static void PrintArrayWithForLoop(int[,] array)
        {
            for (int row = 0; row < array.GetLength(0); row++)
            {
                for (int col = 0; col < array.GetLength(1); col++)
                {
                    Console.Write(array[row, col] + " ");
                }

                Console.WriteLine();
            }
        }

        // Example for overloading of methods
        private static void PrintArrayWithForLoop(char[] array)
        {
            Console.WriteLine("The char array elements are: ");

            for (int index = 0; index < array.Length; index++)
            {
                Console.Write(array[index] + " ");
            }

            Console.WriteLine();
        }

        private static void PrintArrayWithForLoop(int[] array)
        {
            Console.WriteLine("The array elements are: ");

            // 1 2 3 4 5 6
            for (int index = 0; index < array.Length; index++)
            {
                Console.Write(array[index] + " ");
            }

            Console.WriteLine();
        }
    }
}
