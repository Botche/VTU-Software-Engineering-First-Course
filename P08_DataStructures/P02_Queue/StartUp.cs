namespace P02_Queue
{
    using System;
    using System.Collections.Generic;

    public class StartUp
    {
        public static void Main()
        {
            Queue<int> queue = new Queue<int>();

            for (int i = 1; i <= 5; i++)
            {
                queue.Enqueue(i);
            }

            int countOfQueue = queue.Count;
            for (int i = 0; i < countOfQueue; i++)
            {
                Console.WriteLine(queue.Dequeue());
            }
        }
    }
}
