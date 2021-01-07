namespace P02_WorkHours
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            // 16:47 - 16:57
            Console.Write("Enter count of work days in month: ");
            int countOfWorkDays = int.Parse(Console.ReadLine());

            int[] workHoursFirstWorker = new int[countOfWorkDays];
            int[] workHoursSecondWorker = new int[countOfWorkDays];
            int[] workHoursThirdWorker = new int[countOfWorkDays];

            Console.WriteLine("First worker:");
            FillWorkHours(workHoursFirstWorker);
            Console.WriteLine("Second worker:");
            FillWorkHours(workHoursSecondWorker);
            Console.WriteLine("Third worker:");
            FillWorkHours(workHoursThirdWorker);

            double firstAvgWorkHours = CalculateAvgWorkHours(workHoursFirstWorker);
            double secondAvgWorkHours = CalculateAvgWorkHours(workHoursSecondWorker);
            double thirdAvgWorkHours = CalculateAvgWorkHours(workHoursThirdWorker);

            Console.WriteLine($"First worker average work hours: {firstAvgWorkHours:F2}");
            Console.WriteLine($"Second worker average work hours: {secondAvgWorkHours:F2}");
            Console.WriteLine($"Third worker average work hours: {thirdAvgWorkHours:F2}");

            Console.WriteLine("First worker:");
            PrintOvertimeDays(workHoursFirstWorker, firstAvgWorkHours);
            Console.WriteLine("Second worker:");
            PrintOvertimeDays(workHoursSecondWorker, secondAvgWorkHours);
            Console.WriteLine("Third worker:");
            PrintOvertimeDays(workHoursThirdWorker, thirdAvgWorkHours);
        }

        private static void PrintOvertimeDays(int[] workHoursForWorker, double avgWorkHours)
        {
            for (int index = 0; index < workHoursForWorker.Length; index++)
            {
                if (workHoursForWorker[index] > avgWorkHours)
                {
                    Console.WriteLine($"Day with overtime: {index + 1}");
                }
            }
        }

        private static double CalculateAvgWorkHours(int[] workHoursWorker)
        {
            double sumOfWorkHours = 0;
            for (int index = 0; index < workHoursWorker.Length; index++)
            {
                sumOfWorkHours += workHoursWorker[index];
            }

            return sumOfWorkHours / workHoursWorker.Length;
        }

        private static void FillWorkHours(int[] workHoursWorker)
        {
            for (int index = 0; index < workHoursWorker.Length; index++)
            {
                Console.Write($"Enter work hours for day {index + 1}: ");
                int workHours = int.Parse(Console.ReadLine());

                workHoursWorker[index] = workHours;
            }
        }
    }
}
