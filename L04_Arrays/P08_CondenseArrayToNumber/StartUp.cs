namespace P08_CondenseArrayToNumber
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            //int[] numbers = Console.ReadLine()
            //    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
            //    .Select(number => int.Parse(number))
            //    .ToArray();

            //for (int index = 0; index < numbers.Length; index++)
            //{
            //    Console.WriteLine(numbers[index]);
            //}

            SumTwoNumbers(2, 5);
            SumTwoNumbers(5, 10);
            SumTwoNumbers(10, 1);
            SumTwoNumbers(21, -21);
            SumTwoNumbers(3, 234);
        }

        public static void SumTwoNumbers(int firstNumber, int secondNumber)
        {
            Console.WriteLine(firstNumber + secondNumber);
        }
    }
}
