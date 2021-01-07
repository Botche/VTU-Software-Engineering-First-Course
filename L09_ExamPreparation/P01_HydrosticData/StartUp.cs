namespace P01_HydrosticData
{
    using System;
    using System.Text;

    public class StartUp
    {
        public static void Main()
        {
            int daysInMonth = ReadDaysInMonth();

            double[] firstHydroStation = new double[daysInMonth];
            double[] secondHydroStation = new double[daysInMonth];
            double[] thirdHydroStation = new double[daysInMonth];

            Console.WriteLine("First station:");
            FillStationWithInfo(firstHydroStation);

            Console.WriteLine("========================================================");

            Console.WriteLine("Second station:");
            FillStationWithInfo(secondHydroStation);

            Console.WriteLine("========================================================");

            Console.WriteLine("Third station:");
            FillStationWithInfo(thirdHydroStation);

            double avgRainQtyForFirstStation = CalculateAvgRainQty(firstHydroStation);
            double avgRainQtyForSecondStation = CalculateAvgRainQty(secondHydroStation);
            double avgRainQtyForThirdtation = CalculateAvgRainQty(thirdHydroStation);

            Console.WriteLine("========================================================");

            Console.WriteLine($"Average rain quantity for first station: {avgRainQtyForFirstStation:F2}");
            Console.WriteLine($"Average rain quantity for second station: {avgRainQtyForSecondStation:F2}");
            Console.WriteLine($"Average rain quantity for third station: {avgRainQtyForThirdtation:F2}");

            Console.WriteLine("========================================================");

            Console.WriteLine("First station:");
            PrintDaysOverAvgRainQty(firstHydroStation, avgRainQtyForFirstStation);

            Console.WriteLine("Second station:");
            PrintDaysOverAvgRainQty(secondHydroStation, avgRainQtyForSecondStation);

            Console.WriteLine("Third station:");
            PrintDaysOverAvgRainQty(thirdHydroStation, avgRainQtyForThirdtation);
        }

        private static void PrintDaysOverAvgRainQty(double[] hydroStation, double averageRainQuantity)
        {
            for (int index = 0; index < hydroStation.Length; index++)
            {
                double rainQuantity = hydroStation[index];
                if (rainQuantity > averageRainQuantity)
                {
                    Console.WriteLine($"-- Day {index + 1}");
                }
            }
        }

        private static double CalculateAvgRainQty(double[] hydroStation)
        {
            int countOfDays = hydroStation.Length;

            double sumOfRainQuantity = 0;
            for (int index = 0; index < hydroStation.Length; index++)
            {
                double rainQuantity = hydroStation[index];

                sumOfRainQuantity += rainQuantity;
            }

            double averageRainQuantity = sumOfRainQuantity / countOfDays;

            return averageRainQuantity;
        }

        // FOR TESTING NOT FOR GRADE
        private static string HydroStationAsText(double[] hydroStation)
        {
            StringBuilder stringBuilder = new StringBuilder();
            // string text = "";

            for (int index = 0; index < hydroStation.Length; index++)
            {
                double rainQuantityForDay = hydroStation[index];

                stringBuilder.AppendLine($"Rain quantity for {index + 1} day: {rainQuantityForDay}");
                // text += $"Rain quantity for {index + 1} day: {rainQuantityForDay}\n";
            }

            return stringBuilder.ToString().Trim();
            // return text.Trim();
        }

        private static void FillStationWithInfo(double[] hydroStation)
        {
            for (int index = 0; index < hydroStation.Length; index++)
            {
                Console.Write($"-- Enter rain quantity for {index + 1} day: ");
                bool isParsed = double.TryParse(Console.ReadLine(), out double quantityRain);

                if (isParsed == false || quantityRain < 0)
                {
                    Console.WriteLine("Invalid quantity rain!");
                    index--;
                    continue;
                }

                hydroStation[index] = quantityRain;
            }
        }

        private static int ReadDaysInMonth()
        {
            int daysInMonth = 0;
            while (true)
            {
                Console.Write("Enter count of days in month: ");
                string input = Console.ReadLine();

                int.TryParse(input, out daysInMonth);

                if (daysInMonth >= 1 && daysInMonth <= 31)
                {
                    break;
                }

                Console.WriteLine("Invalid count of days in month!");
                Console.WriteLine("===============================");
            }

            return daysInMonth;
        }
    }
}
