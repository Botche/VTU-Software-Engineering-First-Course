namespace L11_ComparableObjects
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Diagnostics.CodeAnalysis;

    public class StartUp
    {
        public static void Main()
        {
            Teacher teacher1 = new Teacher(23, "Gosho");
            Teacher teacher2 = new Teacher(20, "Pesho");
            Teacher teacher3 = new Teacher(22, "Ariel");
            Teacher teacher4 = new Teacher(24, "Query");
            Teacher teacher5 = new Teacher(22, "Kosio");

            List<Teacher> teachers = new List<Teacher>();
            teachers.Add(teacher1);
            teachers.Add(teacher2);
            teachers.Add(teacher3);
            teachers.Add(teacher4);
            teachers.Add(teacher5);

            SortTeachersByAgeDesc comparer = new SortTeachersByAgeDesc();

            teachers.Sort();
            // teachers.Sort(comparer);

            foreach (Teacher teacher in teachers)
            {
                Console.WriteLine($"Age: {teacher.Age}; Name: {teacher.Name}");
            }
        }

        private class SortTeachersByAgeDesc : IComparer<Teacher>
        {
            public int Compare([AllowNull] Teacher firstTeacher, [AllowNull] Teacher secondTeacher)
            {
                if (firstTeacher.Age < secondTeacher.Age)
                {
                    return 1;
                }
                else if (firstTeacher.Age > secondTeacher.Age)
                {
                    return -1;
                }

                return 0;
            }
        }
    }
}
