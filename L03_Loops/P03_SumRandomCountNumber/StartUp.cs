namespace P03_SumRandomCountNumber
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            int countOfNumber = int.Parse(Console.ReadLine());

            int sum = 0;
            for (int index = 0; index < countOfNumber; index++)
            {
                int number = int.Parse(Console.ReadLine());
                sum = sum + number;
            }

            Console.WriteLine(sum);
        }
    }
}
