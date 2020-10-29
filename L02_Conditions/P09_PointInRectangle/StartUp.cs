namespace P09_PointInRectangle
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            const string TEXT_TO_PRINT_IF_IS_INSIDE = "Inside";
            const string TEXT_TO_PRINT_IF_IS_OUTSIDE = "Outside";

            Console.Write("Enter X coordinate of first point: ");
            double x1 = double.Parse(Console.ReadLine());
            Console.Write("Enter Y coordinate of first point: ");
            double y1 = double.Parse(Console.ReadLine());

            Console.Write("Enter X coordinate of second point: ");
            double x2 = double.Parse(Console.ReadLine());
            Console.Write("Enter Y coordinate of second point: ");
            double y2 = double.Parse(Console.ReadLine());

            Console.Write("Enter X coordinate of the point to check if is in rectangle: ");
            double pointX = double.Parse(Console.ReadLine());
            Console.Write("Enter Y coordinate of the point to check if is in rectangle: ");
            double pointY = double.Parse(Console.ReadLine());

            bool isInside = false;

            //if (x1 <= pointX && pointX <= x2)
            //{
            //    if (y1 <= pointY && pointY <= y2)
            //    {
            //        isInside = true;
            //    }
            //}

            if (x1 <= pointX
                && pointX <= x2
                && y1 <= pointY
                && pointY <= y2)
            {
                isInside = true;
            }

            string textToPrint = isInside == true
                ? TEXT_TO_PRINT_IF_IS_INSIDE
                : TEXT_TO_PRINT_IF_IS_OUTSIDE;
            Console.WriteLine(textToPrint);
        }
    }
}
