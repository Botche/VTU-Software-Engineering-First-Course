namespace P04_ListExampleLinq
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            List<int> timeIntervals = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            int indexAtMiddle = timeIntervals.Count / 2;
            // 29 13 9 0 13
            double leftSumOfIntervals
                = CalculateSumOfIntervals(timeIntervals
                    .Take(indexAtMiddle)
                    .ToList());
            // 21 0 14 82 12
            double rightSumOfIntervals
                = CalculateSumOfIntervals(timeIntervals
                    .Skip(indexAtMiddle + 1)
                    .Reverse()
                    .ToList());

            Console.WriteLine(leftSumOfIntervals);
            Console.WriteLine(rightSumOfIntervals);

            bool isLeftTheWinner = leftSumOfIntervals < rightSumOfIntervals;
            string winner = isLeftTheWinner == true ? "left" : "right";
            double winnerTime = isLeftTheWinner == true ? leftSumOfIntervals : rightSumOfIntervals;

            Console.WriteLine($"The winner is {winner} with total time: {winnerTime:F2}.");
            // ===========================================================================================
            bool isLeftTheWinnerSecondVersion = leftSumOfIntervals < rightSumOfIntervals;
            if (isLeftTheWinnerSecondVersion == true)
            {
                Console.WriteLine($"The winner is left with total time: {leftSumOfIntervals:F2}.");
            }
            else
            {
                Console.WriteLine($"The winner is right with total time: {rightSumOfIntervals:F2}.");
            }
        }

        private static double CalculateSumOfIntervals(List<int> timeIntervals)
        {
            double sumOfIntervals = 0;
            for (int index = 0; index < timeIntervals.Count; index++)
            {
                int timeInterval = timeIntervals[index];

                if (timeInterval == 0)
                {
                    sumOfIntervals *= 0.8;
                }

                sumOfIntervals += timeInterval;
            }

            return sumOfIntervals;
        }
    }
}
