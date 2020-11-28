namespace P11_EqualArrays
{
    using System;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            int[] arrayOfNumbers = Console.ReadLine()
                 .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                 .Select(int.Parse)
                 .ToArray();

            int[] arrayOfNumbers2 = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int sumOfTheArrays = 0;
            int indexOfDifference = 0;
            bool areIdentical = true;
            for (int i = 0; i < arrayOfNumbers.Length; i++)
            {
                if (arrayOfNumbers[i] != arrayOfNumbers2[i])
                {
                    areIdentical = false;
                    indexOfDifference = i;
                    break;
                }
            }

            if (areIdentical == false)
            {
                Console.WriteLine($"Arrays are not identical. Found difference at {indexOfDifference} index.");
            }
            else
            {
                sumOfTheArrays = arrayOfNumbers.Sum();

                Console.WriteLine($"Arrays are identical. Sum: {sumOfTheArrays}");
            }

            /*
             int[] arrayOfNumbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int[] arrayOfNumbers2 = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int sumOfTheArrays = 0;
            for (int i = 0; i < arrayOfNumbers.Length; i++)
            {
                if (arrayOfNumbers[i] != arrayOfNumbers2[i])
                {
                    Console.WriteLine($"Arrays are not identical. Found difference at {i} index.");
                    return;
                }
            }
            sumOfTheArrays = arrayOfNumbers.Sum();

            Console.WriteLine($"Arrays are identical. Sum: {sumOfTheArrays}");
             */
        }
    }
}
