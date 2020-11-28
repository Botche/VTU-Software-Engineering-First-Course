namespace P10_MoreExamples
{
    using System;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            int countOfNumbers = int.Parse(Console.ReadLine());

            int[] fisrtArray = new int[countOfNumbers];
            int[] secondArray = new int[countOfNumbers];

            bool isLeftFirst = true;
            for (int index = 0; index < countOfNumbers; index++)
            {
                int[] numbers = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                if (isLeftFirst == true)
                {
                    fisrtArray[index] = numbers[0];
                    secondArray[index] = numbers[1];
                }
                else
                {
                    fisrtArray[index] = numbers[1];
                    secondArray[index] = numbers[0];
                }

                isLeftFirst = !isLeftFirst;
            }

            for (int index = 0; index < fisrtArray.Length; index++)
            {
                Console.Write(fisrtArray[index] + " ");
            }

            Console.WriteLine();

            for (int index = 0; index < secondArray.Length; index++)
            {
                Console.Write(secondArray[index] + " ");
            }
        }
    }
}
