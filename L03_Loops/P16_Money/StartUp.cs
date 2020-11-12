namespace P16_Money
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            double moneyToRefund = double.Parse(Console.ReadLine());

            long countOfMaxCoin = (long)moneyToRefund / 2;
            double newMoneyToRefund = moneyToRefund - (countOfMaxCoin * 2);

            long countOfCoins = countOfMaxCoin;
            while (newMoneyToRefund != 0)
            {
                countOfCoins++;

                if (newMoneyToRefund >= 1)
                {
                    newMoneyToRefund -= 1;
                }
                else if (newMoneyToRefund >= 0.50)
                {
                    newMoneyToRefund -= 0.50;
                }
                else if (newMoneyToRefund >= 0.20)
                {
                    newMoneyToRefund -= 0.20;
                }
                else if (newMoneyToRefund >= 0.10)
                {
                    newMoneyToRefund -= 0.10;
                }
                else if (newMoneyToRefund >= 0.05)
                {
                    newMoneyToRefund -= 0.05;
                }
                else if (newMoneyToRefund >= 0.02)
                {
                    newMoneyToRefund -= 0.02;
                }
                else if (newMoneyToRefund >= 0.01)
                {
                    newMoneyToRefund -= 0.01;
                }

                newMoneyToRefund = Math.Round(newMoneyToRefund, 2);
            }

            Console.WriteLine(countOfCoins);
        }
    }
}
