namespace P02_LatinSymbols
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            int a = 'a'; // implicit
            char aChar = (char)a; // explicit
            
            for (char index = 'a'; index <= 'z'; index++)
            {
                Console.WriteLine(index);
            }
        }
    }
}
