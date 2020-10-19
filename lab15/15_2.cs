using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp15_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //1
            int n;
            n = Convert.ToInt32(Console.ReadLine());
            Stack<int> stack = new Stack<int>();
            for (int i = 0; i < n; i++)
            {
                stack.Push(i);
            }
            foreach (int i in stack)
                Console.Write(i + " ");
            Console.WriteLine();
            //2
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            foreach (int i in stack)
                Console.Write(i + " ");
            Console.WriteLine();
            //3
            Console.WriteLine("Enter number of deleting elements");
            while (true)
            {
                int k = Convert.ToInt32(Console.ReadLine());
                Stack<int> temp = new Stack<int>(stack);
                try
                {
                    for (int i = 0; i < k; i++)
                        stack.Pop();
                    break;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message + " Try again.");
                    stack = temp;
                }
            }
            foreach (int i in stack)
                Console.Write(i + " ");
            if(stack.Count() == 0)
                Console.Write("Stack is empty now");
            Console.WriteLine();
            //4
            stack.Clear();
            //5
            Console.WriteLine(stack.Count() == 0);
        }
}
}
