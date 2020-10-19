using System;
using System.Collections.Generic;
using System.Linq;

/*7.3-1 Дана закодированная последовательность чисел. Написать декодиру-
ющую программу, работающую по следующему алгоритму. Если очередное чис-
ло x положительное, то оно копируется в декодированную последовательность,
если отрицательное, то копируется |x| последних значений из декодированного
потока*/
namespace ConsoleApp15_6
{
    class Program
    {
        public static List<int> solve(List<int> list)
        {
            List<int> decoded = new List<int>();
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] > 0)
                {
                    decoded.Add(list[i]);
                }
                else
                {
                    int fix1 = decoded.Count - Math.Abs(list[i]);
                    int fix2 = decoded.Count;
                    for (int j = fix1; j < fix2; j++)
                    {
                        decoded.Add(decoded[j]);
                    }
                }
            }

            return decoded;
        }

        static void Main(string[] args)
        {
            List<int> list = new List<int>() {1, 2, 3, -2, -3};
            foreach (var i in solve(list))
            {
                Console.Write(i + " ");
            }
        }
    }
}
