namespace P05_RoundingNumbers
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            string input = Console.ReadLine();

            string[] arrayOfNumbers = input.Split(" ");

            for (int index = 0; index < arrayOfNumbers.Length; index++)
            {
                double number = double.Parse(arrayOfNumbers[index]);

                int roundedNumber = (int)Math.Round(number, MidpointRounding.AwayFromZero);
                Console.WriteLine($"{number} => {roundedNumber}");
            }
        }
    }
}
