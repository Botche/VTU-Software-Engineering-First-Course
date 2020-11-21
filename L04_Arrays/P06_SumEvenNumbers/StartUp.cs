namespace P06_SumEvenNumbers
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

            int sum = 0;
            for (int index = 0; index < input.Length; index++)
            {
                int number = int.Parse(input[index]);

                if (number % 2 == 0)
                {
                    sum += number;
                }
            }

            Console.WriteLine(sum);
        }
    }
}
