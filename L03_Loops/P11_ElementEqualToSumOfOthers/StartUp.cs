namespace P11_ElementEqualToSumOfOthers
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            int count = int.Parse(Console.ReadLine());

            int maxNumber = int.MinValue;
            int sum = 0;
            for (int index = 0; index < count; index++)
            {
                int number = int.Parse(Console.ReadLine());

                sum += number;
                if (number > maxNumber)
                {
                    maxNumber = number;
                }
            }

            sum -= maxNumber;

            if (sum == maxNumber)
            {
                Console.WriteLine("Yes");
                Console.WriteLine($"Sum = {sum}");
            }
            else
            {
                Console.WriteLine("No");
                Console.WriteLine($"Diff = {Math.Abs(maxNumber - sum)}");
            }
        }
    }
}
