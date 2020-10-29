namespace P03_BiggerNumber
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());

            int biggerNumber = 0;

            if (firstNumber <= secondNumber)
            {
                biggerNumber = secondNumber;
            }
            else
            {
                biggerNumber = firstNumber;
            }

            Console.WriteLine(biggerNumber);
            //Console.WriteLine($"The smaller number with method from Math class: {Math.Max(firstNumber, secondNumber)}");
        }
    }
}
