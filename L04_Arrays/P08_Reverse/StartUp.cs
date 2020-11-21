namespace P08_Reverse
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            string[] input = Console.ReadLine().Split(" ");

            // This is a house
            for (int index = 0; index < input.Length; index++)
            {
                Console.Write(input[index] + " ");
            }

            Console.WriteLine();

            // house a is This
            for (int index = input.Length - 1; index >= 0; index--)
            {
                Console.Write(input[index] + " ");
            }

            Console.WriteLine();

            // sihT si a esuoh
            // This
            // is
            // a
            // house
            for (int index = 0; index < input.Length; index++)
            {
                string word = input[index];
                for (int indexOfElement = word.Length - 1; indexOfElement >= 0 ; indexOfElement--)
                {
                    Console.Write(word[indexOfElement]);
                }

                Console.Write(" ");
            }

            Console.WriteLine();

            // esuoh a si sihT
            for (int index = input.Length - 1; index >= 0; index--)
            {
                string word = input[index];

                for (int indexOfElement = word.Length - 1; indexOfElement >= 0; indexOfElement--)
                {
                    Console.Write(word[indexOfElement]);
                }

                Console.Write(" ");
            }
        }
    }
}
