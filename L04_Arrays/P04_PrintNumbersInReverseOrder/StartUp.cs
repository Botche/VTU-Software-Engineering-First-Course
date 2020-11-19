namespace P04_PrintNumbersInReverseOrder
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            int count = int.Parse(Console.ReadLine());
            int[] array = new int[count];

            for (int index = 0; index < array.Length; index++)
            {
                int number = int.Parse(Console.ReadLine());

                array[index] = number;
            }

            for (int index = array.Length - 1; index >= 0; index--)
            {
                Console.Write(array[index] + " ");
            }
        }
    }
}
