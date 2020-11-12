namespace P12_OddEvenPositions
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            int count = int.Parse(Console.ReadLine());

            double oddSum = 0;
            double oddMin = 1000000000.0;
            double oddMax = -1000000000.0;
            double evenSum = 0;
            double evenMin = 1000000000.0;
            double evenMax = -1000000000.0;

            for (int index = 1; index <= count; index++)
            {
                int num = int.Parse(Console.ReadLine());

                bool isEvenPosition = index % 2 == 0;
                if (isEvenPosition == true)
                {
                    evenSum += num;
                    if (evenMax < num)
                    {
                        evenMax = num;
                    }

                    if (evenMin > num)
                    {
                        evenMin = num;
                    }
                }
                else
                {
                    oddSum += num;
                    if (oddMax < num)
                    {
                        oddMax = num;
                    }

                    if (oddMin > num)
                    {
                        oddMin = num;
                    }
                }
            }

            Console.WriteLine("Odd Sum= " + oddSum);
            if (oddMax == -1000000000.0)
            {
                Console.WriteLine("Odd Min= No");
                Console.WriteLine("Odd Max= No");
            }
            else
            {
                Console.WriteLine("Odd Min= " + oddMin);
                Console.WriteLine("Odd Max= " + oddMax);
            }

            Console.WriteLine("Even Sum= " + evenSum);

            if (evenMax == -1000000000.0)
            {
                Console.WriteLine("Even Min= No");
                Console.WriteLine("Even Max= No");
            }
            else
            {
                Console.WriteLine("Even Min= " + evenMin);
                Console.WriteLine("Even Max= " + evenMax);
            }
        }
    }
}
