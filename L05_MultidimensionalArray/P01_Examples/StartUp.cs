namespace P01_Examples
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            int countOfRows = 3;
            int[,] numbers = new int[countOfRows, countOfRows];

            for (int row = 0; row < countOfRows; row++)
            {
                for (int col = 0; col < countOfRows; col++)
                {
                    int number = int.Parse(Console.ReadLine());

                    numbers[row, col] = number;
                }
            }

            for (int row = 0; row < countOfRows; row++)
            {
                for (int col = 0; col < countOfRows; col++)
                {
                    Console.Write(numbers[row, col] + " ");
                }

                Console.WriteLine();
            }

            Console.WriteLine();
        }
    }
}
