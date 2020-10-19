using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp15_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            n = Convert.ToInt32(Console.ReadLine());
            List<int> list = new List<int>();
            for (int i = 0; i < n; i++)
            {
                list.Add(i);
            }
            var ret6 = list
                .Where(x => x % 3 != 0);
            list = ret6.ToList();
            foreach(int i in list) 
                Console.Write(i + " ");
            Console.WriteLine();
        }
    }
}
