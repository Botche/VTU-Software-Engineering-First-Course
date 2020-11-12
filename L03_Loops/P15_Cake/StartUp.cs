namespace P15_Cake
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            int widthOfCake = int.Parse(Console.ReadLine());
            int lengthOfCake = int.Parse(Console.ReadLine());

            int countOfCakePieces = widthOfCake * lengthOfCake;
            int counter = 0;
            while (countOfCakePieces > 0)
            {
                string command = Console.ReadLine();
                counter++;

                if (command.ToUpper() == "STOP")
                {
                    Console.WriteLine(counter);
                    break;
                }

                int piecesToTake = int.Parse(command);
                countOfCakePieces = countOfCakePieces - piecesToTake;
            }

            string text = $"{countOfCakePieces} pieces are left.";
            if (countOfCakePieces < 0)
            {
                text = $"No more cake left! You need {Math.Abs(countOfCakePieces)} pieces more.";
            }

            Console.WriteLine(text);
        }
    }
}
