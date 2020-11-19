namespace P02_FillingArray
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            Console.Write("Enter count of numbers: ");
            int countOfNumber = int.Parse(Console.ReadLine());

            int[] numbers = new int[countOfNumber];

            for (int index = 0; index < numbers.Length; index++)
            {
                int number = int.Parse(Console.ReadLine());

                numbers[index] = number;
            }

            // numbers = new int[5];

            Console.WriteLine();

            for (int index = 0; index < numbers.Length; index++)
            {
                Console.Write(numbers[index] + " ");
            }
        }
    }
}
