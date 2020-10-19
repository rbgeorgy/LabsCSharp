using  System;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApplication16_1
{
  internal class Program
  {
    public static void Main(string[] args)
    {
      string path = @Directory.GetCurrentDirectory() + "/myFile.txt";
      string path1 = @Directory.GetCurrentDirectory() + "/myFile1.txt";
      string path2 = @Directory.GetCurrentDirectory() + "/myFile2.txt";
      try
      {
        using (StreamWriter sw = new StreamWriter(path, false, Encoding.Default))
        {
          Console.WriteLine("Введите количество чисел");
          int n = Convert.ToInt32(Console.ReadLine());
          for (int i = 1; i <= n; i++)
          {
            Console.Write("Введите {0}-е число: ", i);
            int x = Convert.ToInt32(Console.ReadLine());
            sw.WriteLine(x);
          }
        }

        using (StreamReader sr = new StreamReader(path, Encoding.Default))
        {
          string line;
          StreamWriter sw1 = new StreamWriter(path1, false, Encoding.Default);
          StreamWriter sw2 = new StreamWriter(path2, false, Encoding.Default);
          sw1.WriteLine("Четные числа:");
          sw2.WriteLine("Нечетные числа:");
          
          int firstSum = 0;
          int secSum = 0;
          int firstCnt = 0;
          int secCnt = 0;


          while ((line = sr.ReadLine()) != null)
          {
            int x = Convert.ToInt32(line);
            if (x % 2 == 0){
              sw1.WriteLine(x);
              firstSum += x;
              firstCnt++;
            }
            else{
              sw2.WriteLine(x);
              secSum += x;
              secCnt++;
            }
          }
          sw1.WriteLine("Сумма:");
          sw1.WriteLine(firstSum);
          sw1.WriteLine("Среднее арифметическое:");
          if (firstCnt != 0) 
            sw1.WriteLine(firstSum / firstCnt); 
          else 
            sw1.WriteLine(0);
          sw2.WriteLine("Сумма:");
          sw2.WriteLine(secSum);
          sw2.WriteLine("Среднее арифметическое:");
          if (secCnt != 0) 
            sw2.WriteLine(firstSum / secCnt); 
          else 
            sw2.WriteLine(0);
          

          sw1.Close();
          sw2.Close();
        }
      }
      catch (Exception e)
      {
        Console.WriteLine(e.Message);
      }
    }
  }
}
