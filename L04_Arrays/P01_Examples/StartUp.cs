namespace P01_Examples
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            char[] array = { 'a', 'i', 'r', 'c', 'r', 'a', 'f', 't' };
            char[] secondArray = { 'b', 'r', 'a', 'n', 'd' };

            Console.WriteLine();

            for (int index = 0; index < array.Length; index++)
            {
                Console.Write(array[index] + " ");
            }

            Console.WriteLine();

            for (int index = array.Length - 1; index >= 0; index--)
            {
                Console.Write(array[index] + " ");
            }
        }
    }
}
