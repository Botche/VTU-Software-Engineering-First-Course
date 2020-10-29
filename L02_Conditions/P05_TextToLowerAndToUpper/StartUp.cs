namespace P05_TextToLowerAndToUpper
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            string text = Console.ReadLine();
            string secondText = Console.ReadLine();

            bool areWordsEqual = false;

            if (text.ToUpper() == secondText.ToUpper())
            {
                areWordsEqual = true;
            }

            Console.WriteLine(areWordsEqual);
        }
    }
}
