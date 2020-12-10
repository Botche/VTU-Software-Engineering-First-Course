namespace P04_RefOutParameters
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            string text = "0";

            // int number = int.Parse(text);

            bool isParsed = int.TryParse(text, out int number);

            Console.WriteLine("My program is awesome");
            Console.WriteLine(isParsed);
            Console.WriteLine(number);
        }
    }
}
