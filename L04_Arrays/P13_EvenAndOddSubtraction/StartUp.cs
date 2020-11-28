namespace P13_EvenAndOddSubtraction
{
    using System;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            int[] numbers = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int evenNumberSum = 0;
            int oddNumberSum = 0;
            for (int index = 0; index < numbers.Length; index++)
            {
                int number = numbers[index];

                if (number % 2 == 0)
                {
                    evenNumberSum += number;
                }
                else
                {
                    oddNumberSum += number;
                }
            }

            int difference = evenNumberSum - oddNumberSum;
            Console.WriteLine(difference);
        }
    }
}
