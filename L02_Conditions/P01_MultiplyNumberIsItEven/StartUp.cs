namespace P01_MultiplyNumberIsItEven
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            const string AMERICAN_CURRENCY_CODE = "USD";
            const string EUROPEIAN_CURRENCY_CODE = "EUR";
            const string ENGLISH_CURRENCY_CODE = "GBP";

            const decimal USD_CURRENCY = 1.79549M;
            const decimal EUR_CURRENCY = 1.95583M;
            const decimal GBP_CURRENCY = 2.53405M;

            decimal money = decimal.Parse(Console.ReadLine());
            string firstCurrency = Console.ReadLine();
            string secondCurrency = Console.ReadLine();

            if (firstCurrency == AMERICAN_CURRENCY_CODE)
            {
                money = money * USD_CURRENCY;
            }
            else if (firstCurrency == EUROPEIAN_CURRENCY_CODE)
            {
                money = money * EUR_CURRENCY;
            }
            else if (firstCurrency == ENGLISH_CURRENCY_CODE)
            {
                money = money * GBP_CURRENCY;
            }

            // switch (firstCurrency)
            // {
            //     case AMERICAN_CURRENCY_CODE:
            //         money = money * USD_CURRENCY;
            //         break;
            //     case EUROPEIAN_CURRENCY_CODE:
            //         money = money * EUR_CURRENCY;
            //         break;
            //     case ENGLISH_CURRENCY_CODE:
            //         money = money * GBP_CURRENCY;
            //         break;
            // }

            // Now money is BGN
            if (secondCurrency == AMERICAN_CURRENCY_CODE)
            {
                money = money / USD_CURRENCY;
            }
            else if (secondCurrency == EUROPEIAN_CURRENCY_CODE)
            {
                money = money / EUR_CURRENCY;
            }
            else if (secondCurrency == ENGLISH_CURRENCY_CODE)
            {
                money = money / GBP_CURRENCY;
            }

            string text = $"{money:F2} {secondCurrency}";
            Console.WriteLine(text);
        }
    }
}
