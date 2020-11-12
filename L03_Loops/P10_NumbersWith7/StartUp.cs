namespace P10_NumbersWith7
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            // 10 / 7 = 1 (3) - MATH
            // 10 / 7 = 1 - CODING
            // 10 % 7 = 3 

            for (int index = 7; index <= 997; index += 10)
            {
                Console.WriteLine(index);
            }

            int counter = 7;
            while (counter <= 997)
            {
                Console.WriteLine(counter);
                counter += 10;
            }
        }
    }
}
