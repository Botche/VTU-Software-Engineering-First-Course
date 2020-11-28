namespace P14_ArrayRotation
{
    using System;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            // 51 47 32 61 21
            // 1

            int[] numbers = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int countOfRotation = int.Parse(Console.ReadLine());
            for (int index = 0; index < countOfRotation; index++)
            {
                for (int indexOfNumbers = 0; indexOfNumbers < numbers.Length - 1; indexOfNumbers++)
                {
                    int temp = numbers[indexOfNumbers];

                    numbers[indexOfNumbers] = numbers[indexOfNumbers + 1];
                    numbers[indexOfNumbers + 1] = temp;
                }
            }

            for (int index = 0; index < numbers.Length; index++)
            {
                Console.Write(numbers[index] + " ");
            }

            //Console.WriteLine(string.Join(' ', numbers));
        }
    }
}
