using System;

namespace ConsoleApp10
{
    class Program
    {
        static void Main(string[] args)
        {
            string tmp = "   2.1. Дана строка на русском      языке, в которой слова    разделены пробелами и знаками препинания. Выведите слова, в которых отсутствует буква «е».    ";
            tmp = tmp.Trim();
            string[] words = tmp.Split(new char[] {' ', ','}, StringSplitOptions.RemoveEmptyEntries);
            //Console.WriteLine(tmp);
            foreach (string word in words)
            {
                if(word.Contains('е'))
                    continue;
                Console.WriteLine(word);
            }
        }
    }
}
