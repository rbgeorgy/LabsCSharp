using  System;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication16_2
{
  internal class Program
  {
    public static void Main(string[] args)
    {
      string path = @Directory.GetCurrentDirectory() + "/myFile.txt";
      string path1 = @Directory.GetCurrentDirectory() + "/myFile1.txt";
      try
      {
        using (StreamReader sr = new StreamReader(path, Encoding.Default))
        {
          string line;
          StreamWriter sw1 = new StreamWriter(path1, false, Encoding.Default);
          List<int> list = new List<int>();
          
          while ((line = sr.ReadLine()) != null)
          {
            int x = Convert.ToInt32(line);
            list.Add(x);
          }

          int max = list.Max();
          for(int i = 0; i < list.Count; i++)
          {
            list[i] += max;
            sw1.WriteLine(list[i]);
          }
          sw1.Close();
        }
      }
      catch (Exception e)
      {
        Console.WriteLine(e.Message);
      }
    }
  }
}
