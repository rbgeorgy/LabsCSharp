using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp15_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //1
            int n;
            n = Convert.ToInt32(Console.ReadLine());
            List<int> list = new List<int>();
            for (int i = 0; i < n; i++)
            {
                list.Add(i);
                Console.Write(list[i] + " ");
            }
            Console.WriteLine();
            //2
            list[0] = -10;
            list[n - 1] = 100;
            foreach(int i in list) 
                Console.Write(i + " "); 
            Console.WriteLine();
            //3
            list.Insert(list.IndexOf(list.Max()) + 1, -1);
            foreach(int i in list) 
                Console.Write(i + " ");
            Console.WriteLine();
            //4
            if (list.Contains(5))
            {
                Console.WriteLine("Элемент со значением 5 присутствует в списке на месте: {0}", list.IndexOf(5));
            }
            else
            {
                 Console.WriteLine("Элемент со значением 5 отсутствует в списке");
            }
            //5
            var ret5 = list
                .Where(x => x >= 0)
                .Except(new[]{list.Max()});
            list = ret5.ToList();
            foreach(int i in list) 
                Console.Write(i + " ");
            Console.WriteLine();
            //6
            var ret6 = list
                .Where(x => list.IndexOf(x) % 2 != 0);
            list = ret6.ToList();
            foreach(int i in list) 
                Console.Write(i + " ");
            Console.WriteLine();
            //7
            list.Clear();
            list = null;
        }
}
}
