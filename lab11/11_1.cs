using System;

namespace ConsoleApp10
{
    class Program
    {
        static void Main(string[] args)
        {
            string tmp = Console.ReadLine();
            tmp = tmp.Remove('А');
            tmp = tmp.Remove('Е');
            tmp = tmp.Remove('а');
            tmp = tmp.Remove('е');
        }
    }
}
