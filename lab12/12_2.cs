using  System;

namespace ConsoleApplication3
{
    class Program
    {
        
        public  delegate bool IsEqual(int x);
        static public int[] Randomize(int n)
        {
            int[] arr = new int[n];
            Random rand = new Random();
            for (int i = 0; i < n; i++)
            {
                arr[i] = rand.Next(-20, 20);
            }

            return arr;
        }

        public static void Print(int[] arr, IsEqual func)
        {
            foreach (int i in arr)
            {
                if (func(i))
                {
                    Console.Write(" "+ i +" ");
                }
            }
            Console.WriteLine();
        }

        public static int Count(int[] arr, IsEqual func)
        {
            int cnt = 0;
            foreach (int i in arr)
            {
                if (func(i))
                {
                    cnt++;
                }
            }
            return cnt;
        }
        
        public static int Sum(int[] arr, IsEqual func, IsEqual func2)
        {
            int sum = 0;
            foreach (int i in arr)
            {
                if (func(i) && func2(i))
                {
                    sum+=i;
                }
            }
            return sum;
        }

        public static void Main(string[] args)
        {
            Console.WriteLine("Введите размер массива:");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] arr = Randomize(n);
            Console.WriteLine("Четные:");
            Print(arr, d => d % 2 == 0);
            Console.WriteLine("Нечетные:");
            Print(arr, d => d % 2 != 0);
            Console.WriteLine("Число положительных:");
            Console.WriteLine(Count(arr, d => d > 0));
            Console.WriteLine("Число отрицательных:");
            Console.WriteLine(Count(arr, d => d < 0));
            Console.WriteLine("Сумма четных положительных:");
            Console.WriteLine(Sum(arr, d => d > 0, i => i%2 == 0));
            Console.WriteLine("Сумма нечетных положительных:");
            Console.WriteLine(Sum(arr, d => d > 0, i => i%2 != 0));
            Console.WriteLine("Сумма четных отрицательных:");
            Console.WriteLine(Sum(arr, d => d < 0, i => i%2 == 0));
            Console.WriteLine("Сумма нечетных отрицательных:");
            Console.WriteLine(Sum(arr, d => d < 0, i => i%2 != 0));


        }
    }
}