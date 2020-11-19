namespace P03_DayOfWeek
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            string[] days =
            {
                "Monday",
                "Tuesday",
                "Wednesday",
                "Thusday",
                "Friday",
                "Saturday",
                "Sunday",
            };

            string command = Console.ReadLine();
            while (command.ToUpper() != "STOP")
            {
                int number = int.Parse(command);

                string textToPrint = "Invalid day!";
                if (number >= 1 && number <= days.Length)
                {
                    textToPrint = days[number - 1];
                }

                Console.WriteLine(textToPrint);
                
                command = Console.ReadLine();
            }
        }
    }
}
