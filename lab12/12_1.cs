using  System;

namespace ConsoleApplication3
{
    class Program
    {

        delegate int Operation(int m, int n);
        public static void Main(string[] args)
        {
            Operation operation = (m, n) => (m + n) * (n - m + 1) / 2;
            Console.WriteLine(operation(23, 27));
            Console.WriteLine(operation(1, 27));
        }
    }
}