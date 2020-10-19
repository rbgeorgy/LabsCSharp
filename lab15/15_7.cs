using System;
using System.Collections.Generic;
using System.Linq;

/*7.4-1 В некоторой коллекции хранятся значения углов в градусах. Соста-
вить LINQ-выражение, выбирающее только острые углы.
Написать программу, применяющую выражение к коллекции из случайных
чисел, а также решающую эту же задачу явно.*/
namespace ConsoleApp15_7
{
    class Program
    {
        static IEnumerable<int> solve1(List<int> list)
        {
            var ret = list
                .Where(x => x < 90);
            return ret;
        }
        
        static IEnumerable<int> solve2(List<int> list)
        {
            List<int> ret = new List<int>();
            foreach (int i in list)
            {
                if (i < 90)
                {
                    ret.Add(i);
                }
            }
            return ret;
        }

        static void Main(string[] args)
        {
            var rand = new Random();
            List<int> list = new List<int>();
            for (int i = 0; i <= 100; i++)
                list.Add(rand.Next(180));

            foreach (var VARIABLE in solve1(list))
            {
                Console.Write(VARIABLE + " ");
            }
            Console.WriteLine("\nAnd the same:\n");
            foreach (var VARIABLE in solve2(list))
            {
                Console.Write(VARIABLE + " ");
            }
        }
    }
}
