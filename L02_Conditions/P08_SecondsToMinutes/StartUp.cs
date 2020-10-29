namespace P08_SecondsToMinutes
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            int firstSeconds = int.Parse(Console.ReadLine());
            int secondSeconds = int.Parse(Console.ReadLine());
            int thirdSeconds = int.Parse(Console.ReadLine());

            int sumOfSeconds = firstSeconds + secondSeconds + thirdSeconds;

            int minutes = sumOfSeconds / 60;
            int seconds = sumOfSeconds % 60;

            // SOLUTION 1
            Console.WriteLine($"{minutes}:{seconds:D2}");
            // ==========

            // SOLUTION 2
            //string secondsToText = string.Empty;
            //secondsToText = seconds < 10
            //    ? $"0{seconds}"
            //    : seconds.ToString();
            // ==========

            // SOLUTION 3
            //if (seconds < 10)
            //{
            //    secondsToText = $"0{seconds}";
            //}
            //else
            //{
            //    secondsToText = seconds.ToString();
            //}
            // ==========

            //Console.WriteLine($"{minutes}:{secondsToText}");
        }
    }
}
