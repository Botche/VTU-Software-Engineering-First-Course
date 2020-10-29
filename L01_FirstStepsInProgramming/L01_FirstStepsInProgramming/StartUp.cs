using System;

namespace L01_FirstStepsInProgramming
{
    class StartUp
    {
        static void Main()
        {
            Console.Write("Enter the first number: ");
            string input = Console.ReadLine();
            int number = int.Parse(input);

            Console.Write("Enter the second number: ");
            string secondInput = Console.ReadLine();
            int secondNumber = int.Parse(secondInput);

            int sum = number + secondNumber;
            Console.WriteLine("The sum is: " + sum);

            int substract = number - secondNumber;
            Console.WriteLine("The substract is: " + substract);

            int multiply = number * secondNumber;
            Console.WriteLine("The multiply is: " + multiply);

            double division = number / (double)secondNumber;
            Console.WriteLine("The division is: " + division);

            int percentage = number % secondNumber;
            Console.WriteLine("The percentage is: " + percentage);
        }
    }
}
