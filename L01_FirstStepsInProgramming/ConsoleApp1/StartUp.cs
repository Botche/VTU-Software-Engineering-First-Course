namespace ConsoleApp1
{
    using System;

    public class StartUp
    {
        static void Main()
        {
            Console.Write("Enter your first name: ");
            string firstName = Console.ReadLine();

            Console.Write("Enter your last name: ");
            string lastName = Console.ReadLine();

            Console.Write("Enter your age: ");
            int age = int.Parse(Console.ReadLine());

            string fullName = firstName + " " + lastName;

            Console.WriteLine($"My name is {fullName}, and I am {age} years old.");
        }
    }
}
