namespace P06_OddAndEvenPositonsSum
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            int countOfNumber = int.Parse(Console.ReadLine());

            int evenPositionsSum = 0;
            int oddPositionsSum = 0;
            for (int index = 0; index < countOfNumber; index++)
            {
                int number = int.Parse(Console.ReadLine());

                bool isEven = index % 2 == 0;
                if (isEven == true)
                {
                    evenPositionsSum += number;
                }
                else
                {
                    oddPositionsSum += number;
                }

                string posititonType = isEven == true ? "even" : "odd";

                Console.WriteLine($"The number is {number}");
                Console.WriteLine($"The position is {index}");
                Console.WriteLine($"The position is {posititonType}");
                Console.WriteLine($"Even sum is {evenPositionsSum}");
                Console.WriteLine($"Odd sum is {oddPositionsSum}");
            }

            int difference = evenPositionsSum - oddPositionsSum;

            string text = $"No, diff = {Math.Abs(difference)}";
            if (difference == 0)
            {
                text = $"Yes, sum = {evenPositionsSum}";
            }

            Console.WriteLine(text);
        }
    }
}
