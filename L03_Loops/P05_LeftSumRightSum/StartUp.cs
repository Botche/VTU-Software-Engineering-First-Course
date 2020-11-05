namespace P05_LeftSumRightSum
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            //int countOfNumbers = int.Parse(Console.ReadLine());

            //int leftSum = 0;
            //for (int index = 0; index < countOfNumbers; index++)
            //{
            //    int number = int.Parse(Console.ReadLine());
            //    leftSum += number;
            //}

            //int rightSum = 0;
            //for (int index = 0; index < countOfNumbers; index++)
            //{
            //    int number = int.Parse(Console.ReadLine());
            //    rightSum = rightSum + number;
            //}

            int countOfNumbers = int.Parse(Console.ReadLine());

            int leftSum = 0;
            int rightSum = 0;
            for (int index = 0; index < countOfNumbers * 2; index++)
            {
                int number = int.Parse(Console.ReadLine());

                if (index < countOfNumbers)
                {
                    leftSum += number;
                }
                else
                {
                    rightSum += number;
                }
            }

            int difference = leftSum - rightSum;

            string text = $"No, diff = {Math.Abs(difference)}";
            if (difference == 0)
            {
                text = $"Yes, sum = {rightSum}";
            }

            Console.WriteLine(text);
        }
    }
}
