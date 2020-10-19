using System;
using System.Text.RegularExpressions;

namespace ConsoleApp10
{
    /*3.1. Дан фрагмент текста на русском языке, запрашиваемый у пользователя. Выведите
на экран все слова, которые начинаются на гласную букву.*/
    class Program
    {
        static void Main(string[] args)
        {
            string tmp = Console.ReadLine();
            Regex reHardcode = new Regex("^[аоиеёэыуюя][А-Яа-я--]*((?=,) | (?=.))*", RegexOptions.IgnoreCase);
            Regex re = new Regex("(?<= )[аоиеёэыуюя]{1}[А-Яа-я--]*((?=,) | (?=.))*", RegexOptions.IgnoreCase);
            foreach (Match m in reHardcode.Matches(tmp))
            {
                Console.WriteLine(m);
                break;
            }

            foreach (Match m in re.Matches(tmp))
                Console.WriteLine(m);
        }
    }
}
