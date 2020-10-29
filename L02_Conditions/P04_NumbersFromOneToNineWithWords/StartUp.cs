namespace P04_NumbersFromOneToNineWithWords
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            int number = int.Parse(Console.ReadLine());

            string text = string.Empty; // ""

            switch (number)
            {
                case 1:
                    text = "one";
                    break;
                case 2:
                    text = "two";
                    break;
                case 3:
                    text = "three";
                    break;
                case 4:
                    text = "four";
                    break;
                case 5:
                    text = "five";
                    break;
                case 6:
                    text = "six";
                    break;
                case 7:
                    text = "seven";
                    break;
                case 8:
                    text = "eight";
                    break;
                case 9:
                    text = "nine";
                    break;
                case 10:
                case 11:
                case 12:
                case 13:
                case 14:
                case 15:
                    text = "Number is in [10, 15]";
                    break;
                default:
                    text = "Error!";
                    break;
            }

            Console.WriteLine(text);
        }
    }
}
