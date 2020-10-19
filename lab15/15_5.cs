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
            int k = Convert.ToInt32(Console.ReadLine());
            List<int> newList = new List<int>();
            for (int i = 0; i < n; i++)
            {
                if(list[i] % k == 0) newList.Add(i);
            }

            foreach (var i in newList)
            {
                list.Insert(list.IndexOf(i), 0);
            }
            
            // foreach(int i in list) 
            //     Console.Write(i + " ");
            // Console.WriteLine();
        }
    }
}
