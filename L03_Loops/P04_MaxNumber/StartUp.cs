namespace P04_MaxNumber
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            int countOfNumber = int.Parse(Console.ReadLine());

            int maxNumber = int.MinValue;
            for (int index = 0; index < countOfNumber; index++)
            {
                int number = int.Parse(Console.ReadLine());

                if (maxNumber < number)
                {
                    maxNumber = number;
                }
            }

            Console.WriteLine(maxNumber);
        }
    }
}
