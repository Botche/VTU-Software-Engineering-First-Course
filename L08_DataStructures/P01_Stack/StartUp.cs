namespace P01_Stack
{
    using System;
    using System.Collections.Generic;

    public class StartUp
    {
        public static void Main()
        {
            Stack<int> stack = new Stack<int>();

            for (int i = 1; i <= 5; i++)
            {
                stack.Push(i);
            }

            // Console.WriteLine(stack.Peek());
            // Console.WriteLine(stack[2]); - CANNOT
            /*
             * STACK: 1, 2, 3, 4, 5
             * 
             * PEEK: 5 => STACK: 1, 2, 3, 4, 5
             * PEEK: 5 => STACK: 1, 2, 3, 4, 5
             * 
             * POP: 5 => STACK: 1, 2, 3, 4
             * POP: 4 => STACK: 1, 2, 3
             * 
             */

            int countOfStack = stack.Count;
            for (int i = 0; i < countOfStack; i++)
            {
                Console.WriteLine(stack.Pop());
            }
        }
    }
}
