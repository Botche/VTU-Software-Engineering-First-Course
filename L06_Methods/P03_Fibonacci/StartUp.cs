namespace P03_Fibonacci
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            #region Fibonacci without recursion
            //int countOfFibonacciNumbers = int.Parse(Console.ReadLine());
            //int[] fibonacciNumbers = new int[countOfFibonacciNumbers];

            //int previousNumber = 1;
            //int previousPreviousNumber = 1;

            //fibonacciNumbers[0] = previousNumber;
            //fibonacciNumbers[1] = previousPreviousNumber;

            //for (int index = 2; index < fibonacciNumbers.Length; index++)
            //{
            //    int sumOfPreviousNumbers = previousNumber + previousPreviousNumber;
            //    fibonacciNumbers[index] = sumOfPreviousNumbers;

            //    previousPreviousNumber = previousNumber;
            //    previousNumber = sumOfPreviousNumbers;
            //}

            //Console.WriteLine(string.Join(", ", fibonacciNumbers));
            #endregion

            #region Fibonacci with recursion
            //int indexOfFibonacciNumber = int.Parse(Console.ReadLine());

            //Console.WriteLine(FindFibonacciNumber(indexOfFibonacciNumber));

            //// 1, 1, 2, 3, 5, 8, 13, 21, 34, 55

            //// index 1 = 1
            //// index 2 = 1
            //// index 3 = 2
            //// index 4 = 3
            //// index 5 = 5
            #endregion

            #region Factorial
            //int factorial = int.Parse(Console.ReadLine());

            //Console.WriteLine(CalculateFactorial(factorial));

            #endregion
        }

        private static int CalculateFactorial(int n)
        {
            if (n == 0 || n == 1)
            {
                return 1;
            }

            return CalculateFactorial(n - 1) * n;
        }

        private static int FindFibonacciNumber(int index)
        {
            if (index <= 2)
            {
                return 1;
            }

            int previousNumber = FindFibonacciNumber(index - 1);
            int previousPreviousNumber = FindFibonacciNumber(index - 2);

            Console.WriteLine($"Previous number: {previousNumber} at index: {index}");
            Console.WriteLine($"Previous previous number: {previousPreviousNumber} at index: {index}");

            return previousNumber + previousPreviousNumber;
        }
    }
}
