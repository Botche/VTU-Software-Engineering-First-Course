namespace P03_List
{
    using System;
    using System.Collections.Generic;

    public class StartUp
    {
        public static void Main()
        {
            List<int> list = new List<int>()
            {
                1, 2, 3, 4, 5, 6, 7, 8, 9
            };

            Console.WriteLine(list.Count);
            Console.WriteLine(list.Capacity);

            List<int> listToAdd = new List<int>()
            {
                11, 12, 23
            };

            //for (int i = 1; i <= 5; i++)
            //{
            //    list.Add(i);
            //}

            //for (int index = 0; index < list.Count; index++)
            //{
            //    Console.WriteLine(list[index]);
            //}
        }
    }
}
