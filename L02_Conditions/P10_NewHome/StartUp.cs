namespace P10_NewHome
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            const string ROSES = "Roses";
            const string DAHLIAS = "Dahlias";
            const string TULIPS = "Tulips";
            const string NARCISSUS = "Narcissus";
            const string GLADIOLUS = "Gladiolus";

            const double ROSES_PRICE = 5;
            const double DAHLIAS_PRICE = 3.80;
            const double TULIPS_PRICE = 2.80;
            const double NARCISSUS_PRICE = 3;
            const double GLADIOLUS_PRICE = 2.50;

            const int COUNT_OF_ROSES_FOR_DISCOUNT = 80;
            const int COUNT_OF_DAHLIAS_FOR_DISCOUNT = 90;
            const int COUNT_OF_TULIPS_FOR_DISCOUNT = 80;
            const int COUNT_OF_NARCISSUS_FOR_INCREASE_PRICE = 120;
            const int COUNT_OF_GLADIOLUS_FOR_INCREASE_PRICE = 80;

            string typeOfFlowers = Console.ReadLine();
            int countOfFlowers = int.Parse(Console.ReadLine());
            int budget = int.Parse(Console.ReadLine());

            double percents = 0;
            double sum = 0;
            bool shouldBeDiscounted = true;
            if (typeOfFlowers == ROSES)
            {
                sum = countOfFlowers * ROSES_PRICE;

                if (countOfFlowers > COUNT_OF_ROSES_FOR_DISCOUNT)
                {
                    percents = 10;
                }
            }
            else if (typeOfFlowers == DAHLIAS)
            {
                sum = countOfFlowers * DAHLIAS_PRICE;

                if (countOfFlowers > COUNT_OF_DAHLIAS_FOR_DISCOUNT)
                {
                    percents = 15;
                }
            }
            else if (typeOfFlowers == TULIPS)
            {
                sum = countOfFlowers * TULIPS_PRICE;

                if (countOfFlowers > COUNT_OF_TULIPS_FOR_DISCOUNT)
                {
                    percents = 15;
                }
            }
            else if (typeOfFlowers == NARCISSUS)
            {
                sum = countOfFlowers * NARCISSUS_PRICE;

                if (countOfFlowers < COUNT_OF_NARCISSUS_FOR_INCREASE_PRICE)
                {
                    percents = 15;
                    shouldBeDiscounted = false;
                }
            }
            else if (typeOfFlowers == GLADIOLUS)
            {
                sum = countOfFlowers * GLADIOLUS_PRICE;

                if (countOfFlowers < COUNT_OF_GLADIOLUS_FOR_INCREASE_PRICE)
                {
                    percents = 20;
                    shouldBeDiscounted = false;
                }
            }

            double percentsToNumber = percents / 100;
            if (shouldBeDiscounted == true)
            {
                sum = sum * (1 - percentsToNumber);
            }
            else
            {
                sum = sum * (1 + percentsToNumber);
            }

            double moneyLeftAfterShopping = budget - sum;
            string textToPrint = $"Not enough money, you need {Math.Abs(moneyLeftAfterShopping):F2} leva more.";
            if (moneyLeftAfterShopping >= 0)
            {
                textToPrint
                    = $"Hey, you have a great garden with {countOfFlowers} {typeOfFlowers} and {moneyLeftAfterShopping:F2} leva left.";
            }

            Console.WriteLine(textToPrint);
        }
    }
}
