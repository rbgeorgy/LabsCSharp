using System;

namespace ConsoleApp8
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                int n = 0;
                try
                {
                    Console.WriteLine("Введите размер массива");
                    n = Convert.ToInt32(Console.ReadLine());
                    if (n <= 0)
                    {
                        throw new Exception("Неудовлетворительный размер массива!");
                    }

                    int[] array = new int[n];
                    Random rand = new Random();
                    for (int i = 0; i < n; i++)
                    {
                        array[i] = rand.Next(1, 5000);
                    }

                    Console.WriteLine("Введите индексы a и b:");
                    int a = Convert.ToInt32(Console.ReadLine());
                    int b = Convert.ToInt32(Console.ReadLine());
                    if (a < 0 || b < 0 || a > n - 1 || b > n - 1)
                    {
                        throw new Exception("Неудовлетворительные границы!");
                    }

                    if (b < a)
                        a ^= b ^= a ^= b; //swap
                    long sum = 0;
                    try
                    {
                        for (int i = a; i <= b; i++)
                        {
                            sum += array[i];
                        }
                    }
                    catch (OverflowException)
                    {
                        Console.WriteLine("Произошло переполнение");
                    }

                    Console.WriteLine("Искомая сума = " + sum);
                }
                catch (FormatException)
                {
                    Console.WriteLine("Неверный формат!");
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }

        }
    }
}
