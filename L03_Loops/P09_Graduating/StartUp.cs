namespace P09_Graduating
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            const double GRADE_TO_PASS_YEAR = 4.00;
            const int STUDY_YEARS = 12;

            string nameOfStudent = Console.ReadLine();

            int counter = 1;
            double sumFromGrades = 0;
            bool isRepeating = false;
            bool isExcluded = false;
            while (counter <= 12)
            {
                double yearGrade = double.Parse(Console.ReadLine());

                if (yearGrade >= GRADE_TO_PASS_YEAR)
                {
                    sumFromGrades += yearGrade;
                    counter++;
                    // counter += 1;
                }
                else if (isRepeating == true)
                {
                    isExcluded = true;
                    break;
                }
                else
                {
                    isRepeating = true;
                }
            }

            if (isExcluded == true)
            {
                Console.WriteLine($"{nameOfStudent} has been excluded at {counter} grade");
            }
            else
            {
                double averageGrade = sumFromGrades / STUDY_YEARS;
                Console.WriteLine($"{nameOfStudent} graduated. Average grade: {averageGrade:F2}");
            }
        }
    }
}
