using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp15_3
{
    class Program
    {
        static void Main(string[] args)
        {
            //1
            int n;
            n = Convert.ToInt32(Console.ReadLine());
            Queue<int> queue = new Queue<int>();
            for (int i = 0; i < n; i++)
            {
                queue.Enqueue(i);
            }
            foreach (int i in queue)
                Console.Write(i + " ");
            Console.WriteLine();
            //2
            int m = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < m; i++)
            {
                queue.Enqueue(i);
            }
            foreach (int i in queue)
                Console.Write(i + " ");
            Console.WriteLine();
            //3
            Console.WriteLine("Enter number of deleting elements");
            while (true)
            {
                int k = Convert.ToInt32(Console.ReadLine());
                Queue<int> temp = new Queue<int>(queue);
                try
                {
                    for (int i = 0; i < k; i++)
                        queue.Dequeue();
                    break;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message + " Try again.");
                    queue = temp;
                }
            }
            foreach (int i in queue)
                Console.Write(i + " ");
            if(queue.Count() == 0)
                Console.Write("Queue is empty now");
            Console.WriteLine();
            //4
            queue.Clear();
            //5
            Console.WriteLine(queue.Count() == 0);
        }
}
}
