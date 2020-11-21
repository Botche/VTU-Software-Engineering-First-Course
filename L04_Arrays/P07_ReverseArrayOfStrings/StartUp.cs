namespace P07_ReverseArrayOfStrings
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            string[] input = Console.ReadLine().Split(" ");

            for (int index = input.Length - 1; index >= 0; index--)
            {
                Console.Write(input[index]);

                if (index != 0)
                {
                    Console.Write(" ");
                }
            }

            Console.Write("Hello");
        }
    }
}
