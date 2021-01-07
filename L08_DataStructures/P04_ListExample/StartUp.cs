namespace P04_ListExample
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

            double leftSumOfIntervals = 0;
            for (int leftIndex = 0; leftIndex < indexAtMiddle; leftIndex++)
            {
                int timeInterval = timeIntervals[leftIndex];

                if (timeInterval == 0)
                {
                    leftSumOfIntervals *= 0.8;
                }

                leftSumOfIntervals += timeInterval;
            }

            double rightSumOfIntervals = 0;
            for (int rightIndex = indexAtMiddle + 1; rightIndex < timeIntervals.Count; rightIndex++)
            {
                int timeInterval = timeIntervals[rightIndex];

                if (timeInterval == 0)
                {
                    rightSumOfIntervals *= 0.8;
                }

                rightSumOfIntervals += timeInterval;
            }

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
    }
}
