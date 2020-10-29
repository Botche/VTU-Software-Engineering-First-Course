namespace P02_EvenOrOdd
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            const string ODD = "odd";
            const string EVEN = "even";

            int number = int.Parse(Console.ReadLine());
            string textToPrint = ODD;

            bool isEven = number % 2 == 0;
            if (isEven == true) // => (isEven)
            {
                textToPrint = EVEN;
            }

            // if (isEven == false) // => (!isEven)
            // {
               
            // }
            Console.WriteLine(textToPrint);
        }
    }
}
