namespace P07_AreThreeNumbersEqual
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            int thirdNumber = int.Parse(Console.ReadLine());

            bool areEqual = firstNumber == secondNumber && secondNumber == thirdNumber;

            Console.WriteLine(areEqual);
        }
    }
}
