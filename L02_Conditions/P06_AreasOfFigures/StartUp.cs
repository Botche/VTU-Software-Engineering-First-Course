namespace P06_AreasOfFigures
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            const string RECTANGLE = "RECTANGLE";
            const string SQUARE = "SQUARE";

            string figure = Console.ReadLine();
            string figureNameToUpper = figure.ToUpper();

            double firstNumber = double.Parse(Console.ReadLine());

            double area = 0;
            if (figureNameToUpper == SQUARE)
            {
                area = firstNumber * firstNumber;
                // area = Math.Pow(firstNumber, 2);
            }
            else if(figureNameToUpper == RECTANGLE)
            {
                double secondNumber = double.Parse(Console.ReadLine());

                area = firstNumber * secondNumber;
            }

            string text = $"The area of {figure.ToLower()} is {area:F2}";
            Console.WriteLine(text);
        }
    }
}
